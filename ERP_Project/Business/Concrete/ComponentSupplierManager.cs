using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using ViewModel;

namespace Business.Concrete
{
    public class ComponentSupplierManager : IComponentSupplierService
    {
        private IComponentSupplierDal _componentSupplierDal;

        public ComponentSupplierManager(IComponentSupplierDal componentSupplierDal )
        {
            _componentSupplierDal = componentSupplierDal;
        }

        public void Add(ComponentSupplier componentSupplier)
        {
            _componentSupplierDal.Add(componentSupplier);
           
        }

        public void Delete(ComponentSupplier componentSupplier)
        {
            _componentSupplierDal.Delete(componentSupplier);
        }

        public List<ComponentSupplier> GetAll()
        {
            return _componentSupplierDal.GetAll();
        }

        public List<ComponentSupplier> GetByComponentId(int componentId)
        {
            return _componentSupplierDal.GetAll(x=>x.ComponentId == componentId);
        }

        public List<ComponentSupplier> ShowAll(int componentId)
        {
            return _componentSupplierDal.ShowAll(x=>x.ComponentId == componentId, x=>x.Component,x=>x.Supplier);
        }


        public List<ComponentViewModel>ComponentDetails()
        {
          var components = _componentSupplierDal.ShowAll(null,x=>x.Component,x=>x.Supplier);

            if(components != null)
            {    
            var componentViewModel = components.Select(x => new ComponentViewModel
            {
                ComponentId = x.ComponentId,
                ComponentCode = x.Component.ComponentCode,
                ComponentDefinition = x.Component.ComponentDefinition,
                MinimumOrderQuantity = x.Component.MinimumOrderQuantity,
                 LeadTime = x.Component.LeadTime,
                 ComponentUnitPrice = x.Component.ComponentUnitPrice,
                 SupplierId = x.Supplier.SupplierId,
                 SupplierName = x.Supplier.SupplierName,
                 SupplierAddress = x.Supplier.SupplierAddress,
                 ComponentSupplierId =x.ComponentSupplierId
            
            }).ToList();

            return componentViewModel;
            }
              else
               return null;
        }

        public ComponentSupplier GetSupplierByComponentId(int componentId)
        {
            return _componentSupplierDal.Get(x=>x.ComponentId == componentId);
        }

        public void Update(ComponentSupplier componentSupplier)
        {
           _componentSupplierDal.Update(componentSupplier);
        }
    }
}
