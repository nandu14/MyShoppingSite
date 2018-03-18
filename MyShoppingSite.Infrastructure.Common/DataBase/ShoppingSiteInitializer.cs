using MyShoppingSite.DataAccess.EntityFramework.Context;
using MyShoppingSite.DataAccess.EntityFramework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyShoppingSite.Infrastructure.Common.DataBase
{
   public class ShoppingSiteInitializer
    {
        public static void Seed(MyShoppingSiteDbContext dbContext)
        {
            if (!dbContext.Roles.Any())
            {
                dbContext.AddRange
                (
                   new Role { RoleName="Admin" }
                );

                dbContext.SaveChangesAsync();
            }
        }
    }
}
