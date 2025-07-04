using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class UserScreen : IEntity
    {
        public int UserScreenId { get; set; }

        public int ScreenId { get; set; }
        public Screen Screen { get; set; }
        public int UserId { get; set; }
        public Users User { get; set; }


    }
}
