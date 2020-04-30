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
        // 21. Views

        // A view file has cshtml extension
        // A view is an HTML template with embedded Razor markup
        // Contains logic to display Model data
       //  Convention for adding views e.g. for HomeController>>> Views\Home\{method_name of View}e.g. for details it details.cshtml

       
        

        
    }
}
