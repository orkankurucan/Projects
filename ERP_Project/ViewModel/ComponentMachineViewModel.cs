using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class ComponentMachineViewModel
    {
        public int ComponentMachineId { get; set; }
        public int MachineId {  get; set; }
        public string MachineName { get; set; }
        public int ComponentId { get; set; }
        public string ComponentCode { get; set; }
        public string ComponentDefinition { get; set; }
        public string SubCode { get; set; }
        public int Capacity {  get; set; }
    }
}
