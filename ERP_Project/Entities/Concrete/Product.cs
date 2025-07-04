using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Product : IEntity
    {
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductDefinition { get; set; }
        public int ProductVersion { get; set; }
        public double ProductPrice { get; set; }
        public int ProductStock { get; set; }
        public ICollection<Components> SubMaterial { get; set; } 
        public ICollection<ProductComponent> ProductComponents { get; set; } 
        public ICollection<OrderDetail> OrderDetails { get; set; }  
        public ICollection<ComponentMachine> ComponentMachines { get; set; }
    }
}
