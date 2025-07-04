using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class ProductionPlanViewModel
    {
        public string ProductCode { get; set; }
        public string SubCode { get; set; }
        public int QuantityToProduce { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Enums.ProductionStatus Status { get; set; }


    }
}
