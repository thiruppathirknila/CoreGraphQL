using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Core.Api.Data;
using Core.Api.Data.Interfaces;
using Core.Api.Data.Services;
using GraphiQl;
using GraphQLCore.Helper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
namespace GraphQLCore
{
    public class Startup
    {
        private static IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            try
            {
           
                
                var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
                _configuration = builder.Build();

                var logsDirectory = Path.Combine(Environment.CurrentDirectory);
                var root = logsDirectory + _configuration.GetSection("LogFilePath").Value;

                if (!Directory.Exists(root))
                {
                    Directory.CreateDirectory(root);
                }

                Log.Logger = new LoggerConfiguration()
                    .ReadFrom.Configuration(_configuration)
                    .WriteTo.RollingFile(root + "\\" + DateTime.Now.ToString("yyyyMMddHHmmssFFF") + ".txt")
                    .CreateLogger();

                Logger.InformationLog($"In Startup.ConfigureServices, Configure Services File Process Startd");
                services.AddRepository();
                services.AddDbContext<StoreDbContext>(options =>
                           options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
                services.AddControllers();
            }
            catch (Exception ex)
            {
                Logger.ErrorLog(ex, $"Exception In Program.ConfigureServices. services={services.ToString()}");
            }
            finally
            {
                Logger.InformationLog($"Out Program.ConfigureServices, Configure Services File Process End");
            }
          
           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseGraphiQl("/graphql");

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });


        }
    }
}
