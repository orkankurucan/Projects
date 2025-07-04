using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;

namespace Business.Concrete
{
    public class SupplierManager : ISupplierService
    {
        private ISupplierDal _supplierDal;

        public SupplierManager(ISupplierDal supplierDal)
        {
            _supplierDal = supplierDal;
        }

        public void Add(Supplier supplier, out string message)
        {
            var existingEntity = _supplierDal.Get(x => x.SupplierName == supplier.SupplierName);
            if (existingEntity == null)
            {
                _supplierDal.Add(supplier);
                message = "Supplier Created";
            }
            else
            {
                message = "Supplier already exists";
                return;
            }

        }

        public void Delete(Supplier supplier, out string message)
        {
            var isEmpty = _supplierDal.GetAll().Any();
            if (isEmpty != null)
            {
                _supplierDal.Delete(supplier);
                message = "Supplier Deleted";

            }
            else
            {
                message = "Nothing to delete";
                return;
            }



        }

        public Supplier Get(string supplierName)
        {
            return _supplierDal.Get(x => x.SupplierName == supplierName);
        }

        public List<Supplier> GetAll()
        {
            return _supplierDal.GetAll();
        }

        public void Update(Supplier supplier, out string message)
        {
            var isEmpty = _supplierDal.GetAll().Any();
            if (isEmpty != null)
            {
                _supplierDal.Update(supplier);
                message = "Supplier Updated";
            }
            else
            {
                message ="Nothing to update";
                return ;
            }
        }
    }


}

