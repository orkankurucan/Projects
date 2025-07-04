using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Supplier :IEntity
    {
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierAddress { get; set; }
        public ICollection<ComponentSupplier> ComponentSuppliers { get; set; }
        public ICollection<PurchaseOrder> PurchaseOrder { get; set; }
    }

}
