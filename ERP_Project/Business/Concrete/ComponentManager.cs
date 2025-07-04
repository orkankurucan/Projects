using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Abstract;
using DataAccess.Concrete;
using ViewModel;

namespace Business.Concrete
{
    public class ComponentManager : IComponentService
    {
        private IComponentDal _componentDal;

        public ComponentManager(IComponentDal componentDal)
        {
            _componentDal = componentDal;
        }

        public void Add(Components submaterial, out string message)
        {
            var existingEntity = _componentDal.Get(x => x.ComponentCode == submaterial.ComponentCode);
            if (existingEntity == null)
            {
                _componentDal.Add(submaterial);
                message = "Component Created";
            }
            else
            {
                message = "Component already exists";
                return;
            }

        }

        
        public void Delete(Components submaterial,out string message)
        {
            var isEmpty = _componentDal.GetAll().Any();
            
            if (isEmpty != null)
            {
                _componentDal.Delete(submaterial);
                message ="Component Deleted";
            }
            else
            {
                message = "Nothing to delete";
                return;
            }
            
        }

        public Components GetByCode(string componentCode)
        {
            return _componentDal.Get(x => x.ComponentCode == componentCode);

        }

        public List<Components> GetAll()
        {
            return _componentDal.GetAll();
        }

        public int GetComponentId(string componentCode)
        {
            return _componentDal.GetAll()
                  .Where(x => x.ComponentCode == componentCode)
                  .Select(x => x.ComponentId)
                  .SingleOrDefault();
        }

        public void Update(Components submaterial,out string message)
        {
            var isEmpty = _componentDal.GetAll().Any();
            if (isEmpty != null)
            {
                _componentDal.Update(submaterial);
                message ="Component Updated";
            }
            else
            {
                message = "Nothing to update";
                return;
            }
            
        }

         public Components GetById(int componentId)
        {
            return _componentDal.Get(x => x.ComponentId == componentId);
        }

    }

}
