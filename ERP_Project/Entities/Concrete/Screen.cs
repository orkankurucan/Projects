using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Screen : IEntity
    {
        public int ScreenId { get; set; }
        public string ScreenName { get; set; }

        public ICollection<UserScreen> UserScreens { get; set; }

       
    }
}