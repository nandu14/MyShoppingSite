using System;
using System.Collections.Generic;
using System.Text;

namespace MyShoppingSite.DataAccess.EntityFramework.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public string ProductName { get; set; }
        public int TotalPrice { get; set; }
        public int CategoryId { get; set; }
        public  Category Category { get; set; }

        public ICollection<PurchaseHistory> Purchases { get; set; }
                                           //  public int PurchaseId { get; set; }
                                           //  public PurchaseHistory PurchaseHistory { get; set; }
                                           // public ICollection<Brand> Brand { get; set; }
                                           // public ICollection<Category> Category { get; set; }

    }
}
