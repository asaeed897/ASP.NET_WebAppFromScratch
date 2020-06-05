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
        // 44. AddSingleton vs AddScoped vs AddTransient

        // AddSingleton
        // With a singleton service, there is only a single instance. An instance is
        // created, when the service is first requested and that single instance is used
        // by all http requests throughout the application.

        // AddScoped
        // With a scoped service we get the same instance within the scope of a given http
        // request but a new instance across different http requests.

        // AddTransient
        // With a transient service a new instance is provided every time an instance is requested
        // whether it is in the scope of the same http request or across different http requests.
    }
}  
