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

namespace Business.Concrete
{
    public class UserScreenManager : IUserScreenService
    {
        private IUserScreenDal _userScreenDal;
        public UserScreenManager(IUserScreenDal userScreenDal)
        {
            _userScreenDal = userScreenDal;
        }

        public void Add(UserScreen userScreen)
        {

            _userScreenDal.Add(userScreen);
        }

        public void Delete(UserScreen userScreen)
        {
           _userScreenDal.Delete(userScreen);
        }

        public List<UserScreen> GetAll()
        {
            return _userScreenDal.GetAll();
        }

        public List<UserScreen> GetAuthorizedScreens(string userName)
        {
            return _userScreenDal.ShowAll(x=>x.User.UserName==userName, x=>x.Screen, x=>x.User);
                
        }

        public List<UserScreen> GetByUserId(int userId)
        {
            return _userScreenDal.GetAll()
                .Where(x=>x.UserId==userId)
                .ToList();
        }

        public UserScreen GetByUserIdAndScreenId(int userId, int screenId)
        {
            return _userScreenDal.Get(x=>x.UserId == userId && x.ScreenId==screenId);
               
                
        }

        public void Update(UserScreen userScreen)
        {
           _userScreenDal.Update(userScreen);
        }

        public List<UserScreen> ShowAuthorizedScreens(int userId)
        {
            return _userScreenDal.ShowAll(x=>x.UserId == userId,x=>x.Screen);
        }
    }

}


