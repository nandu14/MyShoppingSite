using Microsoft.EntityFrameworkCore;
using MyShoppingSite.DataAccess.EntityFramework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyShoppingSite.DataAccess.EntityFramework.Context
{
    public class MyShoppingSiteDbContext: DbContext
    {
        public MyShoppingSiteDbContext(DbContextOptions<MyShoppingSiteDbContext> options)
          : base(options)
        {
        }

        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<PurchaseHistory> PurchaseHistories { get; set; }
    }
}
