using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class ProductComponent : IEntity
    {
        public int ProductComponentId {  get; set; }    
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int ComponentId { get; set; }
        public Components Component { get; set; }
        public int ComponentQuantity { get; set; }
    }
}
