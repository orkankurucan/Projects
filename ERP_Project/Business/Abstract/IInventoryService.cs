using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IInventoryService
    {
        void Add(Inventories inventory);
        List<Inventories> GetAll();
        List<Inventories> GetProducts();
        List<Inventories> GetComponents();
        Inventories GetByComponentCode(string componentCode);
        Inventories GetByProductCode(string productCode);
        void Update(Inventories inventories);
        void Delete(Inventories inventories);
        void MarkComponentsAsArrived();
        void CompleteProductionAndTransferToInventory();
    }
}
