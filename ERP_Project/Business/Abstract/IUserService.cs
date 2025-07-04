using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Abstract;
using Entities.Concrete;
using ViewModel;

namespace Business.Abstract
{
    public interface IUserService
    {
        void Add(Users user, out string message);
        List<Users> GetAll();
        void Delete(Users user, out string message);
        void Update(Users user, out string message);
        //int GetUserIdByUserName(string userName);
        Users LogIn(string userName, string password);
       string GetDepartmentNameByUserId(int id);
       string GetRoleNameByUserId(int id);
       string GetFullNameByUserId(int id);
        Users GetUserByUserName(string userName);
        Users GetUserByUserId(int userId);
        List <UserViewModel> GetUserInformation();
        List<Users> GetUserListByUserId(int userUserId);
       
    }
}
