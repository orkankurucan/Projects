﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IMachineAllocationService
    {
        void Delete(MachineAllocation machineAllocation);
        List<MachineAllocation> GetAll();
    }
}
