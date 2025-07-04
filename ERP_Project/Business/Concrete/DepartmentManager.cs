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
    public class DepartmentManager : IDepartmentService
    {
        private IDepartmentDal _departmentDal;

        public DepartmentManager(IDepartmentDal departmentDal)
        {
            _departmentDal = departmentDal;
        }

        public void Add(Department department, out string message)
        {
            var existingEntity = _departmentDal.Get(x => x.DepartmentName == department.DepartmentName);


            if (existingEntity == null)
            {
                _departmentDal.Add(department);
                message = "Department Created";
            }
            else
            {
                message = "Department already exists";
                return;
            }
        }


        public void Delete(Department department, out string message)
        {
            var isEmpty = _departmentDal.GetAll().Any();
            if (isEmpty != null)
            {
                _departmentDal.Delete(department);
                message = "Department Deleted";
            }
            else
            {
                message = "Nothing to delete";
                return;
            }

        }

        public List<Department> GetAll()
        {
            return _departmentDal.GetAll();
        }

        public void Update(Department department, out string message)
        {
            var isEmpty = _departmentDal.GetAll().Any();
            if (isEmpty != null)
            {
                _departmentDal.Update(department);
                message = "Department Updated";
            }
            else
            {
                message ="Nothing to Update";
                return;
            }
        }
    }
}
