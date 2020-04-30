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
        // 22. Customize View Discovery

        // View() or View(Object model): Looks for a view file with the same name
        // same name as the action method
        // View(string viewName): 
        // Looks for a view file with your own custom name: View("Test.cshtml")
        // You can specify a View name or View file path View("MYViews/Test.cshtml")
        // View file path can be absolute or relative
        // With absolute path .cshtml extension must be specified("MYViews/Test.cshtml")
        // with Relative path don't specify the file extension .cshtml: View("../MyVideo/Test")






    }
}
