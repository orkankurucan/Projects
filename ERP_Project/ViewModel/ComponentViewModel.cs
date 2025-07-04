using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class ComponentViewModel
    {
        public int ComponentId { get; set; }
        public string ComponentCode { get; set; }
        public string ComponentDefinition { get; set; }
        public int MinimumOrderQuantity { get; set; }
        public int LeadTime { get; set; }
        public decimal ComponentUnitPrice { get; set; }
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierAddress { get; set; }
        public int ComponentSupplierId {  get; set; }
        

    }
}
