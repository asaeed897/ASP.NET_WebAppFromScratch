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
        // 46. Install Entity Framework core

        // EntityFrameworkCore has dependency on EntityFrameworkCore.Relational
        // and EntityFrameworkCore.Relational han dependency on EntityFrameworkCore.SqlServer
        // thats why we install EntityFrameworkCore.SqlServer and that will install remaining 2 itself.
    }
}  
