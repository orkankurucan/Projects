﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Role : IEntity
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public ICollection<Users> Users { get; set; }

    }
}
