using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyShoppingSite.DataAccess.EntityFramework.Entities
{
    public class Brand
    {
        
        public int BrandId { get; set; }
       
        public string BrandName { get; set; }
        public ICollection<Product> Products { get; set; }


        //public int ProductId { get; set; }
        //public Product Product { get; set; }
    }
}
