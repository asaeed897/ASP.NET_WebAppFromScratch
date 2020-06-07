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
        // 47. DbContext in Entity Framework core

        // The DbContext class includes a DbSet<TEntity> property
        // for each entity in the model
        // we will use this DBSet property Employees to query and save
        // instances of the Employee Class
        // The LINQ queries against the DbSet<TEntity> will be translated into
        // queries against the underlying database
    }
}  
