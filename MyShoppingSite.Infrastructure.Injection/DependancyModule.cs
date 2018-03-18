using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyShoppingSite.DataAccess.EntityFramework.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyShoppingSite.Infrastructure.Injection
{
    public class DependancyModule
    {
        public void Config(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MyShoppingSiteDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
