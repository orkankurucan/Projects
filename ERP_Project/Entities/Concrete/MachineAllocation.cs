using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class MachineAllocation : IEntity
    {
        public int MachineAllocationId { get; set; }
        public int MachineId { get; set; }
        public int ComponentId { get; set; } // The component being produced
        public string SubCode { get; set; }
        public int QuantityToProduce { get; set; } // How much will be produced
        public DateTime StartDate { get; set; } // When production starts
        public DateTime EndDate { get; set; } // When production ends
        public int ProductionTimeInDays { get; set; } // Time allocated in days

        // Navigation properties
        public Machine Machine { get; set; }
        public Components Component { get; set; }
    }
}
