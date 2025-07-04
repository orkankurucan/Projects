using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{

    public class Inventories : IEntity
    {
        [Key]
        public int InventoryId { get; set; }
        public int InventoryEntityId { get; set; }
        public string InventoryEntityCode { get; set; }
        public string InventoryEntityDefinition { get; set; }
        public int StockQuantity { get; set; }

       
        public Product Product { get; set; }
        public Components Component { get; set; }
        public Enums.InventoryType Type { get; set; }
        public Enums.ShipmentStatus Status { get; set; }=Enums.ShipmentStatus.Free;
    }

}








