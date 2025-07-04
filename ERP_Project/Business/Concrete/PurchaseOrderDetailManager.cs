using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using Enums;
using Microsoft.EntityFrameworkCore;
using ViewModel;


namespace Business.Concrete
{
    public class PurchaseOrderDetailManager : IPurchaseOrderDetailService
    {
        private IOrderDal _orderDal;
        private IOrderDetailDal _orderDetailDal;
        private IProductComponentDal _productComponentDal;
        private IComponentDal _componentDal;
        private IInventoryDal _inventoryDal;
        private IPurchaseOrderDal _purchaseOrderDal;
        private IComponentSupplierDal _componentSupplierDal;

        public PurchaseOrderDetailManager(IOrderDal orderDal, IOrderDetailDal orderDetailDal,
            IProductComponentDal productComponentDal, IComponentDal componentDal, IInventoryDal inventoryDal,
           IPurchaseOrderDal purchaseOrderDal, IComponentSupplierDal componentSupplierDal)
        {
            _orderDal = orderDal;
            _orderDetailDal = orderDetailDal;
            _productComponentDal = productComponentDal;
            _componentDal = componentDal;
            _inventoryDal = inventoryDal;
            _purchaseOrderDal = purchaseOrderDal;
            _componentSupplierDal = componentSupplierDal;

        }

        public void ComponentBuy()
        {
            //  Retrieve all active orders that need to be fulfilled
            var activeOrders = _orderDal.GetAll().Where(o => o.OrderStatus == Enums.OrderStatus.Pending || o.OrderStatus == Enums.OrderStatus.InProduction).ToList();

            // Dictionary to store total components needed across all active orders
            Dictionary<int, int> totalComponentsNeeded = new Dictionary<int, int>();

            // Loop through each order and calculate the components required for production (based on BOM)
            foreach (var order in activeOrders)
            {
                var orderDetails = _orderDetailDal.GetAll().Where(od => od.OrderId == order.OrderId).ToList();

                foreach (var orderDetail in orderDetails)
                {
                    // Get the Bill of Materials (BOM) for each product in the order
                    var productComponents = _productComponentDal.GetAll().Where(pc => pc.ProductId == orderDetail.ProductId).ToList();

                    foreach (var productComponent in productComponents)
                    {
                        // Calculate total required quantity for this component based on the ordered quantity
                        int requiredQuantity = productComponent.ComponentQuantity * orderDetail.Quantity;

                        // Add or update the totalComponentsNeeded dictionary
                        if (totalComponentsNeeded.ContainsKey(productComponent.ComponentId))
                        {
                            totalComponentsNeeded[productComponent.ComponentId] += requiredQuantity;
                        }
                        else
                        {
                            totalComponentsNeeded[productComponent.ComponentId] = requiredQuantity;
                        }
                    }
                }
            }

            //  Check inventory for each component and calculate the deficit
            foreach (var componentId in totalComponentsNeeded.Keys)
            {
                var component = _componentDal.Get(x => x.ComponentId == componentId);
                var currentInventory = _inventoryDal.GetAll()
                    .FirstOrDefault(inv => inv.InventoryEntityId == componentId)?.StockQuantity ?? 0;

                int neededQuantity = totalComponentsNeeded[componentId];
                int deficitQuantity = neededQuantity - currentInventory;

                // If we need more than what's available in the inventory
                if (deficitQuantity > 0)
                {
                    // Ensure that the order respects the minimum order quantity
                    int orderQuantity = Math.Max(deficitQuantity, component.MinimumOrderQuantity);

                    // Find the best supplier for the component (by price or other criteria)
                    var bestSupplier = component.ComponentSuppliers.OrderBy(cs => cs.Component.ComponentUnitPrice).FirstOrDefault();

                    if (bestSupplier != null)
                    {
                        // Create a new purchase order for the deficit quantity
                        var purchaseOrder = new PurchaseOrder
                        {
                            SupplierId = bestSupplier.SupplierId,
                            OrderDate = DateTime.Now,
                            DeliveryDate = DateTime.Now.AddDays(component.LeadTime),
                            Status = Enums.PurchaseOrderStatus.Ordered,
                            PurchaseOrderDetails = new List<PurchaseOrderDetail>()
                        };

                        purchaseOrder.PurchaseOrderDetails.Add(new PurchaseOrderDetail()
                        {
                            PurchaseOrderId = purchaseOrder.PurchaseOrderId,
                            ComponentId = component.ComponentId,
                            OrderQuantity = orderQuantity,
                            Price = bestSupplier.Component.ComponentUnitPrice

                        });

                        //  Save the purchase order
                        _purchaseOrderDal.Add(purchaseOrder);
                    }
                }
            }
        }

        public List<PurchaseOrderViewModel> ComponentBuying()
        {
            List<PurchaseOrderViewModel> purchaseOrderViewModels = new List<PurchaseOrderViewModel>();

            //  Retrieve all active orders
            var activeOrders = _orderDal.GetAll().Where(o => o.OrderStatus == OrderStatus.Pending || o.OrderStatus == OrderStatus.InProduction).ToList();

            // Dictionary to store total components needed across all active orders
            Dictionary<int, int> totalComponentsNeeded = new Dictionary<int, int>();

            //  Loop through each order and calculate the components required for production (based on BOM)
            foreach (var order in activeOrders)
            {
                var orderDetails = _orderDetailDal.GetAll().Where(od => od.OrderId == order.OrderId).ToList();

                foreach (var orderDetail in orderDetails)
                {
                    var productComponents = _productComponentDal.GetAll().Where(pc => pc.ProductId == orderDetail.ProductId).ToList();

                    foreach (var productComponent in productComponents)
                    {
                        int requiredQuantity = productComponent.ComponentQuantity * orderDetail.Quantity;
                        if (totalComponentsNeeded.ContainsKey(productComponent.ComponentId))
                        {
                            totalComponentsNeeded[productComponent.ComponentId] += requiredQuantity;
                        }
                        else
                        {
                            totalComponentsNeeded[productComponent.ComponentId] = requiredQuantity;
                        }
                    }
                }
            }

            // Check inventory and create purchase orders as needed
            foreach (var componentId in totalComponentsNeeded.Keys)
            {
                var component = _componentDal.Get(x => x.ComponentId == componentId);
                var currentInventory = _inventoryDal.GetAll()
                    .FirstOrDefault(inv => inv.InventoryEntityId == componentId)?.StockQuantity ?? 0;

                int neededQuantity = totalComponentsNeeded[componentId];
                int deficitQuantity = neededQuantity - currentInventory;

                if (deficitQuantity > 0)
                {
                    int orderQuantity = Math.Max(deficitQuantity, component.MinimumOrderQuantity);

                    //var bestSupplier = component.ComponentSupplier.OrderBy(cs => cs.ComponentPrice).FirstOrDefault();
                    var supplier = _componentSupplierDal.ShowAll(x=>x.ComponentId==componentId,x=>x.Supplier,x=>x.Component).FirstOrDefault();
    
    
                    if (supplier == null)
                    {
                        throw new Exception("Supplier is null.");
                    }
                    if (supplier.Supplier == null)
                    {
                        throw new Exception("supplier.Supplier is null.");
                    }
                    if (component == null)
                    {
                        throw new Exception("Component is null.");
                    }
                    if (supplier.Component == null)
                    {
                        throw new Exception("supplier.Component is null.");
                    }

                    if (supplier != null)
                    {
                        var purchaseOrderViewModel = new PurchaseOrderViewModel
                        {
                            SupplierId = supplier.SupplierId,
                            SupplierName = supplier.Supplier.SupplierName,
                            ComponentId = componentId,
                            ComponentCode = component.ComponentCode,
                            ComponentDefinition = component.ComponentDefinition,
                            MinimumOrderQuantity = component.MinimumOrderQuantity,
                            OrderQuantity = orderQuantity,
                            Price = supplier.Component.ComponentUnitPrice,
                            OrderDate = DateTime.Now,
                            DeliveryDate = DateTime.Now.AddDays(component.LeadTime),
                            Status = Enums.PurchaseOrderStatus.Ordered,
                        };

                        // Add to the list to be shown in DataGridView
                        purchaseOrderViewModels.Add(purchaseOrderViewModel);

                        // Create the actual purchase order and save it
                        var purchaseOrder = new PurchaseOrder
                        {
                            SupplierId = supplier.SupplierId,
                            OrderDate = DateTime.Now,
                            DeliveryDate = purchaseOrderViewModel.DeliveryDate,
                            Status = PurchaseOrderStatus.Ordered,
                            PurchaseOrderDetails = new List<PurchaseOrderDetail>
                    {
                        new PurchaseOrderDetail
                        {
                            ComponentId = component.ComponentId,
                            OrderQuantity = orderQuantity,
                            Price = supplier.Component.ComponentUnitPrice
                        }
                    }
                        };
                        _purchaseOrderDal.Add(purchaseOrder);
                    }
                }
            }

            return purchaseOrderViewModels;
        }


    }

}


