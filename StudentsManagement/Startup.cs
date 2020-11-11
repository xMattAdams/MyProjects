using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StudentsManagement.Models;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;


namespace StudentsManagement
{
    public class Startup
    {
        private IConfiguration _config;

        public Startup(IConfiguration config)
        {
            _config = config;
        }
        
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddScoped<IStudentRepository, StudentRepoMySQL>();

            services.AddIdentity<IdentityUser, IdentityRole>(options =>

              options.Password.RequireNonAlphanumeric = false)

                 .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddDbContextPool<ApplicationDbContext>(options => options.UseMySql(_config.GetConnectionString("StudentDB")));   //AddDbContextPool nie tworzy nowej instancji, tylko sprawdza, czy ona juz istnieje
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseStatusCodePagesWithReExecute("Error/{0}"); //lepsza pratyka, poniewaz w zrodle strony pokazane 
                //jest, ze w przypadku podania zlego route'a, dla tego zlego route'a wystapil blad 404, a nie wywala Ok 200, gdy pojawi się widok z errorem, poniewaz error wystapil na serwerze
                //dodatkowo route nie zmienia się na /Error/404, tylko pozostaje taki, jaki wpisalismy i dla niego pokazuje się Widoj z błędem
            }

            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });

            app.UseMvc();

        }
    }
}
