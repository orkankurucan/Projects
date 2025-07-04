using System;
using System.Collections.Generic;
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
    public class ComponentMachineManager : IComponentMachineService
    {
        private IComponentMachineDal _componentMachineDal;

        public ComponentMachineManager(IComponentMachineDal componentMachineDal)
        {
            _componentMachineDal = componentMachineDal;
        }

        public void Add(ComponentMachine componentMachine)
        {
            _componentMachineDal.Add(componentMachine);
        }

        public void Delete(ComponentMachine componentMachine)
        {
            _componentMachineDal.Delete(componentMachine);
        }

        public List<ComponentMachine> GetAll()
        {
            return _componentMachineDal.GetAll();
        }

        public ComponentMachine GetBySubCode(string subCode)
        {
            return _componentMachineDal.Get(x => x.SubCode == subCode);
        }

        public void Update(ComponentMachine componentMachine)
        {
            _componentMachineDal.Update(componentMachine);
        }

        public List<ComponentMachineViewModel> AllocationDetails()
        {
            var allocation = _componentMachineDal.ShowAll(null, x => x.Components, x => x.Machine);
            if (allocation != null)
            {
                var componentMachineViewModel = allocation.Select(x => new ComponentMachineViewModel()
                {
                    ComponentMachineId = x.ComponentMachineId,
                    MachineId = x.MachineId,
                    MachineName = x.Machine.MachineName,
                    ComponentId = x.ComponentId,
                    ComponentCode = x.Components.ComponentCode,
                    ComponentDefinition = x.Components.ComponentDefinition,
                    SubCode = x.SubCode,
                    Capacity = x.Machine.CapacityPerDay

                }).ToList();

                return componentMachineViewModel;
            }
            else
                return null;

        }
        

    }
}
