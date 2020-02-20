using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Models.ViewModels;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace MbmStore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<Cart>(sp => SessionCart.GetCart(sp));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddMvc();
            services.AddMemoryCache();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseStatusCodePages();
            }

            app.UseStaticFiles();
            app.UseSession();
            // Generates the url paths that are visually more appealing.
            // The default one is the last one and will be the one where the site 'starts' also knonw as the root
            // This has SEO and Accessibility benefits like its more appealing when sharing a link
            // ^The link is easer to dissect and understand
            app.UseMvc(routes =>
            {
                //This will route will map to ex. http://localhost:63672//Catalogue/MusicCD/Page1
                routes.MapRoute(
                name: null,
                template: "Catalogue/{category}/Page{page:int}",
                defaults: new
                {
                    controller = "Catalogue",
                    action = "Index"
                });
                //This will map to ex. http://localhost:63672//Page1
                routes.MapRoute(
                name: null,
                template: "Page{page:int}",
                defaults: new
                {
                    controller = "Catalogue",
                    action = "Index",
                    productPage = 1
                });
                //This will map to ex. http://localhost:63672//Catalogue/MusicCD
                routes.MapRoute(
                name: null,
                template: "Catalogue/{category}",
                defaults: new
                {
                    controller = "Catalogue",
                    action = "Index",
                    productPage = 1
                });

                routes.MapRoute(
                name: null,
                template: "",
                defaults: new
                {
                    controller = "Catalogue",
                    action = "Index",
                    productPage = 1
                });
                //This route {controller=Catalogue}/{action=Index}/{id?}=http://localhost:63672//
                routes.MapRoute(
                name: "default",
                template: "{controller=Catalogue}/{action=Index}/{id?}");
            });
        }
    }
}
