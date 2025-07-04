using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;
using Enums;

namespace Entities.Concrete
{
    public class ProductionPlan : IEntity
    {
        public int ProductionPlanId { get; set; }
        public int ProductId { get; set; }
        public string SubCode { get; set; }
        public int QuantityToProduce { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Enums.ProductionStatus Status { get; set; }

        public Product Product { get; set; }
        public Components Component { get; set; }
        public MachineAllocation MachineAllocation { get; set; }
        public Inventories Inventory { get; set; }
        public OrderDetail OrderDetail { get; set; }
        public ProductComponent ProductComponent { get; set; }
        public Order Order { get; set; }
        public ComponentMachine ComponentMachine { get; set; }
        public Machine Machine { get; set; }
        public ICollection<MachineAllocation> MachineAllocations { get; set; }
    }
    
}
