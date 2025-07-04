using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class PurchaseOrderViewModel
    {   
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public int ComponentId { get; set; }
        public string ComponentCode { get; set; }
        public string ComponentDefinition { get; set; }
        public int MinimumOrderQuantity { get; set; }
        public int OrderQuantity { get; set; }
        public decimal Price { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public Enums.PurchaseOrderStatus Status { get; set; }

    
    }
}
