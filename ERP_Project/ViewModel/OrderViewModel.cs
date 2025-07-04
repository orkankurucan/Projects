using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class OrderViewModel
    {
        public int OrderDetailId { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public int OrderId { get; set; }
        public string CustomerOrderNumber { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductDefinition { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public Enums.OrderStatus OrderStatus { get; set; }

    }
}
