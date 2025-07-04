using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class LogInManager : ILogInService
    {
        private IUserDal _userDal;
        private IUserScreenDal _userScreenDal;

        public LogInManager(IUserDal userDal, IUserScreenDal userScreenDal)
        {
            _userDal = userDal;
            _userScreenDal = userScreenDal;
        }
        public Users LogIn(string userName, string password)
        {
            var user = _userDal.GetAll().SingleOrDefault(u => u.UserName == userName && u.UserPassword == password);
            if (user != null)
            { 
                SessionManager.LoggedInUserId = user.UserId;
               return user;
            }
            
            return null;
         
        }
    }
}
