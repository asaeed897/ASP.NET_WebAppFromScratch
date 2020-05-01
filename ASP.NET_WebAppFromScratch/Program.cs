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
        // 30. _ViewStart in ASP.NET Core MVC

        // Code in ViewStart is executed before the code in an individual view
        // Move the Common code such as setting the Layout property to ViewStart
        // ViewStart reduces code redundancy and improves maintainability
        // ViewStart file is hierarchical So when we place a another _ViewStart file in any subfolder
        // then it can override main _ViewStart file
        // We can also set Layout property in specific view files to change their view if we want




    }
}
