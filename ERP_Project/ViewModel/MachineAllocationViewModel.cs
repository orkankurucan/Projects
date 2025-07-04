using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class MachineAllocationViewModel
    {
        public int MachineId { get; set; }            // ID of the machine
        public string MachineName { get; set; }       // Name of the machine
        public int ComponentId { get; set; }          // ID of the component being processed
        public string ComponentCode { get; set; }     // Code of the component being processed
        public int QuantityToProduce { get; set; }    // Quantity of the component to be processed
        public DateTime StartDate { get; set; }       // When the machine starts processing
        public DateTime EndDate { get; set; }         // When the machine finishes processing
        public int ProductionTimeInDays { get; set; } // Number of days required to process
    }
}
