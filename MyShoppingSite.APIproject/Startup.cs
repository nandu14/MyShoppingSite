using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MyShoppingSite.DataAccess.EntityFramework.Context;
using MyShoppingSite.Infrastructure.Common.DataBase;
using MyShoppingSite.Infrastructure.Injection;

namespace MyShoppingSite.APIproject
{
    public class Startup
    {
        private readonly DependancyModule _injection;
        public Startup(IConfiguration configuration)
        {
            _injection = new DependancyModule();
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            _injection.Config(services, Configuration);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<MyShoppingSiteDbContext>();
                ShoppingSiteInitializer.Seed(context);
            }
        }
    }
}
