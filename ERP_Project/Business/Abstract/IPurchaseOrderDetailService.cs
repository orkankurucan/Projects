using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace Business.Abstract
{
    public interface IPurchaseOrderDetailService
    {
        void ComponentBuy();
        List<PurchaseOrderViewModel> ComponentBuying();
        
    }
}
