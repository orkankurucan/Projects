using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IRoleService
    {
        void Add(Role role,out string message);
        void Delete(Role role, out string message);
        List<Role> GetAll();
        void Update(Role role, out string message);
    }
}
