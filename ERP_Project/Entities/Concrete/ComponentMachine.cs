using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class ComponentMachine :IEntity
    {
        public int ComponentMachineId { get; set; }
        public int MachineId { get; set; }
        public int ComponentId { get; set; }
        public int ProductId { get; set; }
        public string SubCode { get; set; }
        public Machine Machine { get; set; }
        public Components Components { get; set; }
        public Product Product { get; set; }

    }
}
