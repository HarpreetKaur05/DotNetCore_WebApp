using System;
using System.IO;
using Lamar.Microsoft.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting; 
using Serilog;
using Serilog.Events;

namespace MVCCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
            .Enrich.FromLogContext()              
             .CreateLogger();

            try
            {
                Log.Information("Starting web host");
            
                CreateHostBuilder(args).Build().Run();                
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Host terminated unexpectedly");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
              .UseLamar()
              .UseSerilog((hostingContext, loggerConfiguration) => loggerConfiguration.WriteTo.File("log.txt", rollingInterval:RollingInterval.Day))
              .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseContentRoot(Directory.GetCurrentDirectory());                    
                    webBuilder.UseStartup<Startup>();
                });
        

    }
}
