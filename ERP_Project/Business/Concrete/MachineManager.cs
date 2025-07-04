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
    public class MachineManager : IMachineService
    {
        private IMachineDal _machineDal;

        public MachineManager (IMachineDal machineDal)
        {
            _machineDal = machineDal;
        }

        public void Add(Machine machine,out string message)
        {
            var existingEntity = _machineDal.Get(x=>x.MachineName==machine.MachineName);
            if (existingEntity == null)
            {
                _machineDal.Add(machine);
                message = "Machine Created";

            }
            else
            {
                message ="Machine already exists";
                return;
            }
           
        }

        public void Delete(Machine machine,out string message)
        {
            var isEmpty = _machineDal.GetAll().Any();
            if (isEmpty != null)
            {
                _machineDal.Delete(machine);
                message = "Machine Deleted";

            }
            else
            {
                message="Nothing to Delete";
                return;
            }
           
        }

        public Machine Get(string MachineName)
        {
           return _machineDal.Get(x=>x.MachineName == MachineName);
        }

        public List<Machine> GetAll()
        {
            return _machineDal.GetAll();
        }

        public void Update(Machine machine,out string message)
        {
            var isEmpty = _machineDal.GetAll().Any();
            if (isEmpty != null)
            {
                _machineDal.Update(machine);
                message ="Machine Updated";

            }
            else
            {
                message ="Nothing to Update";
                return;
            }
            
        }
    }
}
