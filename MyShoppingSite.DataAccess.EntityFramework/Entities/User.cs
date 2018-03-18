using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyShoppingSite.DataAccess.EntityFramework.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; }
        public ICollection<PurchaseHistory>Purchases { get; set; }
        // public int PurchaseId { get; set; }
        // public PurchaseHistory PurchaseHistory { get; set; }
    }
}
