using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NET_WebAppFromScratch.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_WebAppFromScratch.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public string Index()
        {
            return _employeeRepository.GetEmployee(1).Name;
        }
        public ViewResult Details()
        {
            Employee model = _employeeRepository.GetEmployee(1);
            ViewData["Employee"] = model;
            ViewData["PageTitle"] = "Employee Details";
            return View();
        }
    }
}
