using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IUserScreenService
    {
        void Add(UserScreen userScreen);
        List<UserScreen> GetAll();
        List<UserScreen> GetAuthorizedScreens(string userName);
        UserScreen GetByUserIdAndScreenId(int userId, int screenId);
        void Update (UserScreen userScreen);
        void Delete(UserScreen userScreen);
        List<UserScreen> GetByUserId(int userId);
         List<UserScreen> ShowAuthorizedScreens(int userId);
        
    }
}
