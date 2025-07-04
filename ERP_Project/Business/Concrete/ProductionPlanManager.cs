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
    public class ProductionPlanManager : IProductionPlanService
    {
        private IOrderDal _orderDal;
        private IOrderDetailDal _orderDetailDal;
        private IProductComponentDal _productComponentDal;
        private IComponentDal _componentDal;
        private IInventoryDal _inventoryDal;
        private IMachineDal _machineDal;
        private IComponentMachineDal _componentMachineDal;
        private IProductionPlanDal _productionPlanDal;
        private IProductDal _productDal;

        public ProductionPlanManager
            (
            IOrderDal orderDal,
            IOrderDetailDal orderDetailDal,
            IProductComponentDal productComponentDal,
            IComponentDal componentDal,
            IInventoryDal inventoryDal,
            IMachineDal machineDal,
            IComponentMachineDal componentMachineDal,
            IProductionPlanDal productionPlanDal,
            IProductDal productDal
            )
        {
            _orderDal = orderDal;
            _orderDetailDal = orderDetailDal;
            _productComponentDal = productComponentDal;
            _componentDal = componentDal;
            _inventoryDal = inventoryDal;
            _machineDal = machineDal;
            _componentMachineDal = componentMachineDal;
            _productionPlanDal = productionPlanDal;
            _productDal = productDal;
        }

        public List<ProductionPlan> CreateProductionPlan()
        {
            List<ProductionPlan> productionPlans = new List<ProductionPlan>();

            //  Retrieve product orders and delivery dates
            var orders = _orderDal.GetAll().Where(o => o.OrderStatus == Enums.OrderStatus.Pending).ToList(); // Only fetch orders with "Pending" status

            foreach (var order in orders)
            {
                var orderDetails = _orderDetailDal.ShowAll(od => od.OrderId == order.OrderId, x => x.Order).ToList();

                foreach (var orderDetail in orderDetails)
                {
                    //  Check if a production plan already exists for this order detail to avoid re-processing
                    var existingPlans = _productionPlanDal.ShowAll(pp => pp.OrderDetail.OrderDetailId == orderDetail.OrderDetailId).ToList();

                    if (existingPlans.Count > 0)
                    {
                        // Skip if production plans already exist for this order detail
                        continue;
                    }

                    //  Get product stock from inventory
                    var productInventory = _inventoryDal.Get(i => i.InventoryEntityId == orderDetail.ProductId && i.Type == Enums.InventoryType.Product);
                    int productStock = productInventory != null ? productInventory.StockQuantity : 0;

                    //  Get related components from the BOM and their quantities
                    var productComponents = _productComponentDal.GetAll().Where(pc => pc.ProductId == orderDetail.ProductId).ToList();

                    foreach (var productComponent in productComponents)
                    {
                        int componentId = productComponent.ComponentId;
                        int requiredQuantity = productComponent.ComponentQuantity * orderDetail.Quantity; // Multiply by order quantity

                        //  Get component stocks from inventory
                        var componentInventory = _inventoryDal.Get(i => i.InventoryEntityId == componentId && i.Type == Enums.InventoryType.Component);
                        int componentStock = componentInventory != null ? componentInventory.StockQuantity : 0;

                        //  Get the matching ComponentMachine records to find SubCodes
                        var componentMachines = _componentMachineDal.GetAll(cm => cm.ProductId == orderDetail.ProductId && cm.ComponentId == componentId).ToList();

                        if (componentMachines.Count == 0)
                        {
                            continue; // If no matching component machine is found, skip this iteration
                        }

                        //  Iterate over all ComponentMachines (for different machines producing this component)
                        foreach (var componentMachine in componentMachines)
                        {
                            string subCode = componentMachine.SubCode;

                            // Create production plan entity for each SubCode
                            var productionPlan = new ProductionPlan
                            {
                                ProductId = orderDetail.ProductId,
                                SubCode = subCode,
                                QuantityToProduce = requiredQuantity,
                                StartDate = DateTime.Now, // Set the current date as the start date
                                EndDate = order.DeliveryDate.AddDays(-1), // End one day before the delivery date
                                Status = Enums.ProductionStatus.Waiting,

                                // Navigation properties
                                Product = orderDetail.Product,
                                Component = productComponent.Component,
                                Order = order,
                                OrderDetail = orderDetail,
                                ComponentMachine = componentMachine
                            };

                            // Add the production plan to the list and save it to the database
                            productionPlans.Add(productionPlan);
                            _productionPlanDal.Add(productionPlan);
                        }
                    }

                    //  Update the status of OrderDetail to 'In Production'
                    orderDetail.Order.OrderStatus = Enums.OrderStatus.InProduction;
                    _orderDetailDal.Update(orderDetail);

                    //  Update the order status if all details are in production
                    var allOrderDetails = _orderDetailDal.ShowAll(od => od.OrderId == order.OrderId).ToList();
                    bool allDetailsInProduction = allOrderDetails.All(od => od.Order.OrderStatus == Enums.OrderStatus.InProduction);

                    if (allDetailsInProduction)
                    {
                        order.OrderStatus = Enums.OrderStatus.InProduction;
                        _orderDal.Update(order);
                    }
                }
            }

            return productionPlans;
        }


        public List<ProductionPlanViewModel> GetProductionPlans()
        {
            var productionPlans = _productionPlanDal.ShowAll(null, x => x.Product);

            if (productionPlans != null)
            {
                var productionPlanViewModel = productionPlans.Select(x => new ProductionPlanViewModel
                {
                    ProductCode = x.Product.ProductCode,
                    SubCode = x.SubCode,
                    QuantityToProduce = x.QuantityToProduce,
                    StartDate = x.StartDate,
                    EndDate = x.EndDate,
                    Status = x.Status,


                }).ToList();

                return productionPlanViewModel;
            }
            else
                return null;
        }






        public List<ProductionPlan> GetAll()
        {
            return _productionPlanDal.GetAll();
        }

        public List<ProductionPlan> ShowAll()
        {
            return _productionPlanDal.ShowAll(null, x => x.Product);
        }

        public void Add(ProductionPlan productionPlan)
        {
            _productionPlanDal.Add(productionPlan);
        }
    }



}










