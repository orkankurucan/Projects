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
    public class ScreenManager : IScreenService
    {
        private IScreenDal _screenDal;

        public ScreenManager(IScreenDal screenDal)
        {
            _screenDal = screenDal;
        }

        public void Add(Screen screen, out string message)
        {
            var existingEntity = _screenDal.Get(x => x.ScreenName == screen.ScreenName);
            if (existingEntity == null)
            {
                _screenDal.Add(screen);
                message = "Screen Added";
            }
            else
            {
                message = "Screen already exists";
                return;
            }
        }

        public void Delete(Screen screen, out string message)
        {
            var isEmpty = _screenDal.GetAll().Any();
            if (isEmpty != null)
            {
                _screenDal.Delete(screen);
                message = "Screen Deleted";
            }
            else
            {
                message = "Nothing to Delete";
                return;
            }
        }

        public List<Screen> GetAll()
        {
            return _screenDal.GetAll();

        }

        public Screen GetByScreenName(string screenName)
        {
            return _screenDal.Get(x=>x.ScreenName == screenName);
        }


        public void Update(Screen screen, out string message)
        {
            var isEmpty = _screenDal.GetAll().Any();

            if (isEmpty != null)
            {
                _screenDal.Update(screen);
                message = "Screen Updated";
            }
            else
            {
                message = "Nothing to Update";
                return;
            }




        }
    }
}
