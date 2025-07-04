using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class User : IEntity
    {
        public int UserId { get; set; } // begins with 0, increments by 1
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int DepartmentId { get; set; } // begins with 10, increments by 1
        public string Department { get; set; }
        public int RoleId { get; set; } // begins with 20, increments by 1
        public string Role { get; set; }
        public string PhoneNumber { get; set; }
        public string SupervisorUserName { get; set; }
        public string Address { get; set; }
        public ICollection<UserScreen> UserScreens { get; set; }


        



    }
}
