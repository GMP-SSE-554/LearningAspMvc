using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using LearningAspMvc.Models;

namespace LearningAspMvc
{
    public class Startup
    {
        /// <summary>
        /// Configures the services.
        /// </summary>
        /// <param name="services">The services.</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddScoped<EventAndMenuContext>();
        }

        /// <summary>
        /// Configures the specified application.
        /// </summary>
        /// <param name="app">The application.</param>
        /// <param name="env">The env.</param>
        /// <param name="logger">The logger.</param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory logger)
        {
            // Logger
            logger.AddConsole();
            logger.AddDebug();

            // App
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
            app.UseMvc(routes => routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action}/{id?}",
                    defaults: new { controller = "Home", action = "Index" }
                ).MapRoute(
                    name: "personalId",
                    template: "{controller}/{action}/{personalId?}",
                    defaults: new { controller = "Home", action = "Index" },
                    constraints: new { personalId = @"\d+" }
                ).MapRoute(
                    name: "additionOp",
                    template: "{controller}/{action}/{x}/{y}",
                    defaults: new { controller = "Home", action = "Add" },
                    constraints: new {x = @"\d+", y = @"\d+"}
                ));

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
