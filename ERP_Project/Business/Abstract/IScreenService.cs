﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IScreenService
    {
        void Add(Screen screen, out string message);
        void Delete(Screen screen, out string message);
        List<Screen> GetAll();
        void Update(Screen screen, out string message);
        Screen GetByScreenName(string screenName);
    }
}
