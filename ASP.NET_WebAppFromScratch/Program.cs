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
        // 35. Tag Helpers in ASP.NET Core MVC

        // Some others methods which we can use instead of Tag Helper
        // Manually generating links
        // <a href ="/home/details/@employee.Id">View</a>
        // HTML Helper
        //  @Html.ActionLink("View", "details", "home", new { id= employee.Id}) Its creates entire href link
        // <a href= "@Url.Action("View", "details", "home", new { id= employee.Id})" It return only string link
        //           class="btn btn-primary">View</a>

    }
}
