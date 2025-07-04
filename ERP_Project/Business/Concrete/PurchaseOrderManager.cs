using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class PurchaseOrderManager :IPurchaseOrderService
    {
        private IPurchaseOrderDal _purchaseOrderDal;
        public PurchaseOrderManager(IPurchaseOrderDal purchaseOrderDal)
        {
            _purchaseOrderDal = purchaseOrderDal;
        }
    }
}
