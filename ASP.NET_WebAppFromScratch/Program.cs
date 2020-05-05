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
        // 37. Image Tag Helper in ASP.NET Core MVC

        // Image Tag Helper enhance the <img> tag to provide cache-busting behaviour
        // for static image files
        // Based on the content of the image , a unique hash value is calculated and appended Image URL
        // Each time the image on the server changes a new hash value is calculated and cached

    }
}
