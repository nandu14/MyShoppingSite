using System;
using System.Collections.Generic;
using System.Text;

namespace MyShoppingSite.DataAccess.EntityFramework.Entities
{
    public class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public ICollection<User> User { get; set; }
    }
}
