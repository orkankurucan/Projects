using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using DataAccess.Concrete;
using System.Data.Entity;
using Enums;

namespace Business.Concrete
{
    public class InventoryManager : IInventoryService
    {
        private IInventoryDal _inventoryDal;
        private IPurchaseOrderDal _purchaseOrderDal;
        private IComponentDal _componentDal;
        private IProductionPlanDal _productionPlanDal;
        private IOrderDal _orderDal;
        private IOrderDetailDal _orderDetailDal;

        public InventoryManager(IInventoryDal inventoryDal, IPurchaseOrderDal purchaseOrderDal, IComponentDal componentDal,
            IProductionPlanDal productionPlanDal, IOrderDal orderDal, IOrderDetailDal orderDetailDal)
        {
            _inventoryDal = inventoryDal;
            _purchaseOrderDal = purchaseOrderDal;
            _componentDal = componentDal;
            _productionPlanDal = productionPlanDal;
            _orderDal = orderDal;
            _orderDetailDal = orderDetailDal;
        }

        public void Add(Inventories inventory)
        {
            _inventoryDal.Add(inventory);

        }

        public void Delete(Inventories inventories)
        {
            _inventoryDal.Delete(inventories);
        }

        public List<Inventories> GetAll()
        {
            return _inventoryDal.GetAll();
        }

        public Inventories GetByComponentCode(string componentCode)
        {
            return _inventoryDal.Get(x => x.InventoryEntityCode == componentCode);
        }

        public Inventories GetByProductCode(string productCode)
        {
            return _inventoryDal.Get(x => x.InventoryEntityCode == productCode);
        }

        public List<Inventories> GetComponents()
        {
            var components = Enums.InventoryType.Component;
            return _inventoryDal.GetAll()
                .Where(x => x.Type == components)
                .ToList();

        }

        public List<Inventories> GetProducts()
        {
            var products = Enums.InventoryType.Product;
            return _inventoryDal.GetAll()
                .Where(x => x.Type == products)
                .ToList();
        }

        public void Update(Inventories inventories)
        {
            _inventoryDal.Update(inventories);
        }

        public void MarkComponentsAsArrived()
        {
            var orderedPurchaseOrders = _purchaseOrderDal.ShowAll(po => po.Status == Enums.PurchaseOrderStatus.Ordered,
            x => x.PurchaseOrderDetails, x => x.Supplier);

            foreach (var purchaseOrder in orderedPurchaseOrders)
            {
                foreach (var orderDetail in purchaseOrder.PurchaseOrderDetails)
                {
                    purchaseOrder.Status = Enums.PurchaseOrderStatus.Received;

                    var component = _componentDal.Get(c => c.ComponentId == orderDetail.ComponentId);

                    var inventory = _inventoryDal.Get(i => i.InventoryEntityId == component.ComponentId && i.Type == Enums.InventoryType.Component);

                    if (inventory != null)
                    {
                        inventory.StockQuantity += orderDetail.OrderQuantity;
                        _inventoryDal.Update(inventory);
                    }
                    else
                    {
                        // If the component is not found in inventory, create a new entry
                        var newInventory = new Inventories
                        {
                            InventoryEntityId = component.ComponentId,
                            InventoryEntityCode = component.ComponentCode,
                            InventoryEntityDefinition = component.ComponentDefinition,
                            StockQuantity = orderDetail.OrderQuantity,
                            Type = Enums.InventoryType.Component 
                        };
                        _inventoryDal.Add(newInventory); // This will save the new inventory entry
                    }
                }

                //  Update the purchase order status to 'Arrived'
                _purchaseOrderDal.Update(purchaseOrder); // This will save the updated purchase order status
            }
        }

        public void CompleteProductionAndTransferToInventory()
        {
            // Retrieve all production plans with status 'Waiting' or 'In Production'
            var productionPlans = _productionPlanDal.ShowAll(pp => pp.Status == Enums.ProductionStatus.InProcess).ToList();

            foreach (var plan in productionPlans)
            {
                // : Set production plan status to 'Finished'
                plan.Status = Enums.ProductionStatus.Finished;
                _productionPlanDal.Update(plan);

                // Transfer produced quantities to Inventory
                var existingInventory = _inventoryDal.Get(i => i.InventoryEntityId == plan.ProductId && i.Type == Enums.InventoryType.Product);

                if (existingInventory != null)
                {
                    // If the product already exists in inventory, update its stock quantity
                    existingInventory.StockQuantity += plan.QuantityToProduce;
                    _inventoryDal.Update(existingInventory);
                }
                else
                {
                    // If the product is not in inventory, create a new inventory entry
                    var newInventory = new Inventories
                    {
                        InventoryEntityId = plan.ProductId,
                        InventoryEntityCode = plan.Product.ProductCode,
                        InventoryEntityDefinition = plan.Product.ProductDefinition,
                        StockQuantity = plan.QuantityToProduce,
                        Type = Enums.InventoryType.Product
                    };
                    _inventoryDal.Add(newInventory);
                }

                // Check if all OrderDetails for this order are now finished
                var orderDetails = _orderDetailDal.ShowAll(od => od.OrderId == plan.Order.OrderId, x => x.Order, x => x.Customer).ToList();
                bool allOrderDetailsFinished = orderDetails.All(od => od.Order.OrderStatus == Enums.OrderStatus.Pending);

                // If all OrderDetails are finished, mark the order as completed
                if (allOrderDetailsFinished)
                {
                    plan.Order.OrderId = plan.Order.OrderId;
                    plan.Order.CustomerId = plan.Order.CustomerId;
                    plan.Order.CustomerOrderNumber = plan.Order.CustomerOrderNumber;
                    plan.Order.DeliveryDate = plan.Order.DeliveryDate;

                    plan.Order.OrderStatus = Enums.OrderStatus.Completed;
                    _orderDal.Update(plan.Order);
                }
            }
        }



    }
}
