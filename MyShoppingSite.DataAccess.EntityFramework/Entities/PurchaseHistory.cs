using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyShoppingSite.DataAccess.EntityFramework.Entities
{
    public class PurchaseHistory
    {
        [Key]
        public int PurchaseId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

      //  public ICollection<User> User { get; set; }
      //  public ICollection<Product> Product { get; set; }
    }
}
