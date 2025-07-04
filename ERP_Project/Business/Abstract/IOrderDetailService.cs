using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using ViewModel;

namespace Business.Abstract
{
    public interface IOrderDetailService
    {
        void Add(OrderDetail orderDetail);
        void Delete(OrderDetail orderDetail);
        List<OrderDetail> GetAll();
        void Update(OrderDetail orderDetail, out string message);
        List<OrderViewModel> OrderInformation();
    }
}
