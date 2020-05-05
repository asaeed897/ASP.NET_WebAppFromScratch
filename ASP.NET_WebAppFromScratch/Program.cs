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
        // 38. Environment Tag Helper in ASP.NET Core MVC

        // If we use these environment tag helper just like I did in layout file
        // Then our application download bootstrap file from CDN in case of staging or production environment
        // or if CDN server is down
        // and in Development environment it download this from our own server
        // Here integrity attribute on the <Link> element is used for Subresource 
        // integrity (SRI )check
        // Fallback Source used where bootstrap file didn't download properly and
        // then we want our app to download that from our own server
        // asp-fallback-href attribute use to specify a fallback source
        // And asp-suppress-fallback-integrity attribute use to turn off integrity
        // check for files downloaded from fallback source
    }
}
