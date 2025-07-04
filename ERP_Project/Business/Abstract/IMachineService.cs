using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IMachineService
    {
        List<Machine> GetAll();
        Machine Get(string MachineName);
        void Add (Machine machine,out string message);
        void Delete (Machine machine,out string message);
        void Update (Machine machine, out string message);
    }
}
