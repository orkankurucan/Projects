using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class UserViewModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string SupervisorUserName { get; set; }
        public string Address { get; set; }
        public int DepartmentId { get; set; }
        public string Department { get; set; }
        public int RoleId { get; set; }
        public string Role { get; set; }
    }
}
