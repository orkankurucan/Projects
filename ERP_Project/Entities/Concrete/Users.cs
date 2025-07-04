using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Users : IEntity
    {
        [Key]
        public int UserId { get; set; } 
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string SupervisorUserName { get; set; }
        public string Address { get; set; }

        public int DepartmentId { get; set; } 
        public Department Department { get; set; }
        public int RoleId { get; set; } 
        public Role Role { get; set; }

        public ICollection<UserScreen> UserScreens { get; set; }


    }
}
