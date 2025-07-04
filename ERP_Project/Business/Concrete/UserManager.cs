using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using ViewModel;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;
        private UserScreenDal _userScreenDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(Users user, out string message)
        {
            var existingEntity = _userDal.Get(x => x.UserName == user.UserName);

            if (existingEntity == null)
            {
                _userDal.Add(user);
                message = "User Created";
            }
            else
                message = "User already exists";
            return;


        }

        public void Delete(Users user, out string message)
        {
            var isEmpty = _userDal.GetAll().Any();

            if (isEmpty != null)
            {
                _userDal.Delete(user);
                message = "User Deleted";
            }
            else
            {
                message = "Nothing To Delete";
                return;
            }
        }

        public List<Users> GetAll()
        {
            return _userDal.GetAll();
        }

        public void Update(Users user, out string message)
        {
            var existingEntity = _userDal.GetAll().Any();

            if (existingEntity != null)
            {
                _userDal.Update(user);
                message = "User Updated";

            }
            else
            {
                message = "Nothing To Update";
                return;
            }

        }

        public Users LogIn(string userName, string password)
        {
            var user = _userDal.Get(u => u.UserName == userName && u.UserPassword == password);

            if (user == null)
                throw new UnauthorizedAccessException("Invalid User Name or Password");

          
            return user;
        }

        public string GetDepartmentNameByUserId(int userId)
        {
            string departmentName = _userDal.Get(x => x.UserId == userId).Department.DepartmentName;
            if (departmentName == null)
                return "Department not found";
            else
                return departmentName;
        }

        public string GetRoleNameByUserId(int userId)
        {
            string roleName = _userDal.Get(x => x.UserId == userId).Role.RoleName;
            if (roleName == null)
                return "Role not found";
            else
                return roleName;
        }


        public string GetFullNameByUserId(int userId)
        {
            var user = _userDal.Get(x => x.UserId == userId);

            if (user == null)
                return "User not found";

            else
                return $"{user.Name} {user.Surname}";
        }

        public Users GetUserByUserName(string userName)
        {
            return _userDal.Get(x => x.UserName == userName);
        }

        public Users GetUserByUserId(int userId)
        {
            return _userDal.Get(x => x.UserId == userId);
        }
        
        public List<UserViewModel>GetUserInformation()
        {
          var users = _userDal.ShowAll(null,x=>x.Department,x=>x.Role);

            if(users != null)
            {    
            // Map the Users entity to UserViewModel
            var userViewModels = users.Select(user => new UserViewModel
            {
                UserId = user.UserId,
                UserName = user.UserName,
                Password = user.UserPassword,
                Name = user.Name,
                Surname = user.Surname,
                PhoneNumber = user.PhoneNumber,
                SupervisorUserName = user.SupervisorUserName,
                Address = user.Address,
                DepartmentId = user.DepartmentId,
                Department = user.Department.DepartmentName,
                RoleId = user.RoleId,
                Role = user.Role?.RoleName  
            }).ToList();

            return userViewModels;
            }
              else
               return null;
        }

        public List<Users> GetUserListByUserId(int userUserId)
        {
            return _userDal.ShowAll(x=>x.UserId == userUserId,x=>x.Department,x=>x.Role);
        }
        


    }

}

