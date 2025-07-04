using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
       private IOrderDal _orderDal;

        public OrderManager (IOrderDal orderDal )
        {
            _orderDal = orderDal;
        }

        public void Add(Order order)
        {
            _orderDal.Add(order);
        }

        public void Delete(Order order)
        {
           _orderDal.Delete(order);
        }

        public List<Order> GetAll()
        {
            return _orderDal.GetAll();
        }

        public Order GetOrderByNumber(string orderNumber)
        {
            return _orderDal.GetAll()
                .FirstOrDefault(x=>x.CustomerOrderNumber == orderNumber);
        }

        public void Update(Order order)
        {
            _orderDal.Update(order);
        }

    }
}
