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
        // 36. Why use Tag Helpers in ASP.NET Core MVC

        // Tag helpers generate link based on Application route template
        // its mean if change this template like below
        // endpoints.MapControllerRoute(name: "default",
        //       pattern: "Saeed/{controller=Home}/{action=Index}/{id?}");
        // then Tag helper work here perfectly 

    }
}
