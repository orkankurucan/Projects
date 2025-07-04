using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class ComponentSupplier : IEntity
    {
        public int ComponentSupplierId { get; set; }
        public int ComponentId { get; set; }
        public Components Component { get; set; }
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }


    }
}
