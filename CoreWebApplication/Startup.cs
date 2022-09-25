using CoreWebApplication.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CoreWebApplication
{
    public class Startup
    {
        private IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextPool<AppDbContext>(
                options => options.UseSqlServer(_configuration.GetConnectionString("UserDbConnecttion")));

            services.AddMvc().AddXmlDataContractSerializerFormatters();
            services.AddSingleton<IOrderRepositiory, MockOrderRepository>();
            //services.AddSingleton<IUserRepostory, MockOrderRepository>();
            services.AddScoped<IUserRepostory, SqlUserRepository>();
            //services.AddTransient<IUserRepostory, MockOrderRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILogger<Startup> logger)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseStatusCodePagesWithRedirects("/Error/{0}");
            }
            app.UseStaticFiles();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            app.Run(async (content) =>
            {
                await content.Response.WriteAsync("Hello World");
            });

        }
    }
}
