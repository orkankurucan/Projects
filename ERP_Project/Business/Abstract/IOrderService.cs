using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOrderService
    {
        void Add(Order order);
        Order GetOrderByNumber(string orderNumber);
        List<Order> GetAll();
        void Delete(Order order);
        void Update(Order order);
    }
}
