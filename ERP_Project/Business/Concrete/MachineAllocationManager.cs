using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public  class MachineAllocationManager : IMachineAllocationService
    {
        private IMachineAllocationDal _machineAllocationDal;

        public MachineAllocationManager (IMachineAllocationDal machineAllocationDal)
        {
            _machineAllocationDal = machineAllocationDal;
        }

        public List<MachineAllocation> GetAll()
        {
            return _machineAllocationDal.GetAll();
        }

       
        public void Delete(MachineAllocation machineAllocation)
        {
            _machineAllocationDal.Delete(machineAllocation);
        }
    }
}
