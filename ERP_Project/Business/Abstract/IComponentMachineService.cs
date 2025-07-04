using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using ViewModel;

namespace Business.Abstract
{
    public interface IComponentMachineService
    {
        void Add(ComponentMachine componentMachine);
        void Delete(ComponentMachine componentMachine);
        List<ComponentMachine> GetAll();
        void Update(ComponentMachine componentMachine);
        ComponentMachine GetBySubCode(string subCode);
        List<ComponentMachineViewModel> AllocationDetails();
    }
}
