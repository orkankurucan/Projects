using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public abstract class SessionManager
    {
        public static int LoggedInUserId { get; set; }

    }
}
