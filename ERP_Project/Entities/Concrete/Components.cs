using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Components : IEntity
    {
        [Key]
        public int ComponentId { get; set; }
        public string ComponentCode { get; set; }
        public string ComponentDefinition { get; set; }
        public int MinimumOrderQuantity { get; set; }
        public int LeadTime { get; set; }
        public decimal ComponentUnitPrice { get; set; }
        public ICollection<ComponentSupplier> ComponentSuppliers { get; set; }
        public ICollection<ProductComponent> ProductComponents { get; set; } 
        public ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; } 
        public ICollection<ComponentMachine> ComponentMachines { get; set; } 
    }


}

