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
        // 31. _ViewImports file in ASP.NET Core MVC

        // ViewImport file is placed in the Views folder
        // Used to include the common namespaces
        // To include the common namespaces use @using directive
        // Other Supported directives
        // @addTagHelper
        // @removeTagHelper
        // @tagHelperPrefix
        // @model
        // @inherits
        // @inject
        // ViewImports file is hierarchical just like viewStart



    }
}
