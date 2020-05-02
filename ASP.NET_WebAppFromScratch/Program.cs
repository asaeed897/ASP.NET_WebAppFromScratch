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
        // 33. Attributes Routing in ASP.NET Core MVC

        // With Attribute Routing, [Route] attribute is used to define the Routes
        // Route attribute can be applied on the Controller or the Controller Action Methods
        // With Attributes Routing, routes are placed next to the action methods that will actually use them
        // Attributes routes offer a bit more flexibility than conventional routes
        // Attribute Routes are also hierarchical like ViewStart
        // We can also use [controller], [action] and [area] Tokens instead of using specific names

        // Note: The controller route template is not combined with action method 
        // route template if the on the action method begins with "/" or "~/"

    }
}
