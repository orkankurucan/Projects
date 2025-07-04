using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IDepartmentService
    {
        void Add(Department department,out string message);
        void Delete(Department department,out string message);
        List<Department> GetAll();
        void Update(Department department, out string message);
    }
}
