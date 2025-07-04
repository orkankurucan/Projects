using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    public enum ProductionStatus
    {
        Waiting,
        InProcess,
        Finished
    }

    public enum InventoryType
    {
        Product,
        Component
    }
    public enum OrderStatus
    {
        Pending,
        InProduction,
        Completed,
        Shipped
    }
    public enum PurchaseOrderStatus
    {
        Ordered,
        Received,
    }
    public enum ShipmentStatus
    {
       Free,
       Reserved,
       Shipped,
    }

}
