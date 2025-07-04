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
    public class RoleManager : IRoleService
    {
        private IRoleDal _roleDal;

        public RoleManager(IRoleDal roleDal)
        {
            _roleDal = roleDal;
        }

        public void Add(Role role,out string message)
        {
            var existingEntity = _roleDal.Get(x=>x.RoleName== role.RoleName);

            if (existingEntity == null)
            { 
                _roleDal.Add(role);
                message="Role Created";
            }
            else
            {
                message = "Role already exists";
                return;
            }

        }

        public void Delete(Role role, out string message)
        {
            var isEmpty = _roleDal.GetAll().Any();
            if(isEmpty !=null)
            { 
                _roleDal.Delete(role);
                message ="Role Deleted";
            }

            else
            {
                message ="Nothing to delete";
                return;
            }

        }

        public List<Role> GetAll()
        {
           return _roleDal.GetAll();
        }

        public void Update(Role role,out string message)
        {
            var isEmpty = _roleDal.GetAll().Any();

            if (isEmpty != null)
            {
                _roleDal.Update(role);
                message = "Role Updated";

            }

            else
            {
                message ="Nothing to update";
                return;
            }

        }
    }
}
