using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Pang.GeneralRepository.Core.Core;
using Pang.GeneralRepository.Extensions.Core;
using Pang.GeneralRepository.Web.Data;
using Pang.GeneralRepository.Web.Entities;

namespace Pang.GeneralRepository.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddLoginUserInfo();

            services.AddAutoMapper();
            //services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddGeneralRepository<SimpleDbContext>();
            services.AddDbContext<SimpleDbContext>(option =>
            {
                option.UseSqlite("Data Source=simple.db");
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();
            app.UseLoginUserInfo();
            app.UseAutoMapperMiddleware();
            app.UseRepositoryQuickMiddleware<SimpleDbContext>();

            //app.UseGRCMiddleware<SimpleDbContext>();

            app.UseRouting();

            //app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}