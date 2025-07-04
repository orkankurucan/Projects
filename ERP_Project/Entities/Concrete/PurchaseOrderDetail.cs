using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class PurchaseOrderDetail : IEntity
    {
        public int PurchaseOrderDetailId { get; set; }
        public int PurchaseOrderId { get; set; }
        public int ComponentId { get; set; }
        public int OrderQuantity { get; set; }
        public decimal Price { get; set; }
        public PurchaseOrder PurchaseOrder { get; set; }
        public Components Component { get; set; }

    }
}
