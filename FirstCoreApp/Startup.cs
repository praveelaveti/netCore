using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstCoreApp.Repository;
using FirstCoreApp.RepositoryService;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace FirstCoreApp
{
    public class Startup
    {

        public Startup()
        {

        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSingleton<IEmployeeRepository, EmployeeRepServices>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
               
                app.UseDeveloperExceptionPage();
            }
            //app.UseDefaultFiles();
            app.UseStaticFiles();
            //app.UseMvc();
            //app.UseMvcWithDefaultRoute();   //Default Routing
            //Conventional Routing
            app.UseMvc(route =>
            {
                route.MapRoute("Default", "{Controller=Home}/{Action=Index}/{id?}");
            });
            //app.UseFileServer();
            //app.Run(async (context) =>
            //{
            //throw new Exception();
            //await context.Response.WriteAsync("Hello World!");
            //});
        }
    }
}
