using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Machine : IEntity
    {
        public int MachineId { get; set; }
        public string MachineName { get; set; }
        public string MachineProcess { get; set; }
        public int CapacityPerDay { get; set; }
       public bool isAvaliable { get; set; } =true;
        public TimeSpan SetupTime { get; set; } = TimeSpan.FromSeconds(60);
        
        public ICollection<ComponentMachine> ComponentMachine { get; set; } 

    }

}
