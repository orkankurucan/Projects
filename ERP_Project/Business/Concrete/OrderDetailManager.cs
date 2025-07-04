using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using ViewModel;


namespace Business.Concrete
{
    public class OrderDetailManager : IOrderDetailService
    {
        private IOrderDetailDal _orderDetailDal;
        public OrderDetailManager(IOrderDetailDal orderDetailDal)
        {
            _orderDetailDal = orderDetailDal;
        }

        public void Add(OrderDetail orderDetail)
        {
           var order = _orderDetailDal.Get(x=>x.Order.CustomerOrderNumber==orderDetail.Order.CustomerOrderNumber);
            if(order == null)
           _orderDetailDal.Add(orderDetail);
            else
                return;
            
            
        }

        public void Delete(OrderDetail orderDetail)
        {
           _orderDetailDal.Delete(orderDetail);
        }

        public List<OrderDetail> GetAll()
        {
            return _orderDetailDal.GetAll();
        }

        public void Update(OrderDetail orderDetail,out string message)
        {
            var isEmpty = _orderDetailDal.GetAll().Any();
            if (isEmpty != null)
            {
                _orderDetailDal.Update(orderDetail);
                message ="Order Updated";
            }
            else
            {
                message ="Nothing to Update";
                return;
            }
            
        }

        public List<OrderViewModel> OrderInformation()
        {
            var orders = _orderDetailDal.ShowAll(null,x=>x.Order,x=>x.Customer, x=>x.Product);

            if(orders != null)
            {    
            var orderViewModel = orders.Select(x => new OrderViewModel
            {
                OrderDetailId = x.OrderDetailId,
                CustomerId =x.CustomerId,
                CustomerName = x.Customer.CustomerName,
                CustomerAddress = x.Customer.CustomerAddress,
                OrderId = x.OrderId,
                CustomerOrderNumber =x.Order.CustomerOrderNumber,
                ProductId = x.ProductId,
                ProductCode = x.Product.ProductCode,
                ProductDefinition = x.Product.ProductDefinition,
                Quantity = x.Quantity,
                OrderDate = x.Order.OrderDate,
                DeliveryDate = x.Order.DeliveryDate,
                OrderStatus = x.Order.OrderStatus,
               
            
            }).ToList();

            return orderViewModel;
            }
              else
               return null;
        }



    }
}
