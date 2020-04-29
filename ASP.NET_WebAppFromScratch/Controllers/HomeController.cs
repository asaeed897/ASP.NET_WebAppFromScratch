using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_WebAppFromScratch.Controllers
{
    public class HomeController : Controller
    {
        public JsonResult Index()
        {
            return Json(new { ide =1, name = "Awais"});
        }
    }
}
