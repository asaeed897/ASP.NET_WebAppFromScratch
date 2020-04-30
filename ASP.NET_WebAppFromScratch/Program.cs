using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace ASP.NET_WebAppFromScratch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
        // 24. Passing data to View by ViewBag

        // ViewBag VS ViewData

        // ViewBag is wrapper around ViewData
        // Creates a loosely typed view
        // ViewData uses string keys to store and retrieve data 
        // ViewBag used dynamic properties to store and retrieve
        // Resolved dynamically at runtime
        // No compile - time type checking and Intellisens
        // Preferred approach to pass data from a controller to a view is by using strongly Typed View





    }
}
