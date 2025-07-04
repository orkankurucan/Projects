using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class ProductionOrder :IEntity
    {
        public int ProductionOrderId { get; set; }
        public int ProductionPlanId { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductDefinition { get; set; }
        public int Quantity { get; set; }
        public DateTime ProductionDate { get; set; }
        public string Status { get; set; }

        // Navigation properties
        //public ProductionPlan ProductionPlan { get; set; }
        public Product Product { get; set; }
    }

    public enum Status
    {
        Waiting,
        InProcess,
        Finished
    }



}
