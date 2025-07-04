using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using ViewModel;

namespace Business.Abstract
{
  public interface IComponentSupplierService
    {
        void Add(ComponentSupplier componentSupplier);
        void Delete(ComponentSupplier componentSupplier);
        List<ComponentSupplier> GetAll();
        List<ComponentSupplier> ShowAll(int componentId);
        List<ComponentSupplier> GetByComponentId(int componentId);
        List<ComponentViewModel>ComponentDetails();
        ComponentSupplier GetSupplierByComponentId(int componentId);
        void Update(ComponentSupplier componentSupplier);

    }
}
