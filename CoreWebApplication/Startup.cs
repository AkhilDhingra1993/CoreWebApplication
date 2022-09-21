using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
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
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILogger<Startup> logger)
        {
            if (env.IsDevelopment())
            {
                DeveloperExceptionPageOptions developerExceptionPageOptions = new DeveloperExceptionPageOptions()
                {
                    SourceCodeLineCount = 10//number of exceptions we need to display in the web page
                };
                app.UseDeveloperExceptionPage(developerExceptionPageOptions);
            }


            //DefaultFilesOptions defaultFilesOptions = new DefaultFilesOptions();
            //defaultFilesOptions.DefaultFileNames.Clear();
            //defaultFilesOptions.DefaultFileNames.Add("foo.html");

            //app.UseDefaultFiles(defaultFilesOptions);

            //FileServerOptions defaultFilesOptions = new FileServerOptions();
            //defaultFilesOptions.DefaultFilesOptions.DefaultFileNames.Clear();
            //defaultFilesOptions.DefaultFilesOptions.DefaultFileNames.Add("foo.html");

            //app.UseFileServer(defaultFilesOptions);

            app.UseRouting();
            //app.UseStaticFiles();
            app.UseFileServer();

            app.Run(async (content) =>
            {
                throw new Exception("Some error in processing the request");
                await content.Response.WriteAsync("Hello World");

            });
           
        }
    }
}
