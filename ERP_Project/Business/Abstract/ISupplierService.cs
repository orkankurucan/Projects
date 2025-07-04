using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ISupplierService
    {
        void Add(Supplier supplier,out string message);
        List <Supplier> GetAll();
        void Delete(Supplier supplier,out string message);
        void Update(Supplier supplier, out string message);
        Supplier Get(string supplierName);
    }
}
