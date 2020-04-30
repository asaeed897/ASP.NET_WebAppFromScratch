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
        // 23. Passing data to View by ViewData

        // Three methods to pass data  1. ViewData  2. ViewBag  3. StronglyTyped View

        // Dictionary of weakly typed objects
        // Use string keys to store and retrieve data
        // Dynamically resolved at runtime data 
        // No compile - time type checking and Intellisens





    }
}
