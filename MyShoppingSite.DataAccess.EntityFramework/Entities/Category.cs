using System;
using System.Collections.Generic;
using System.Text;

namespace MyShoppingSite.DataAccess.EntityFramework.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public ICollection<Product> Products{ get; set; }

        //public int ProductId { get; set; }
        //public Product Product { get; set; }
    }
}
