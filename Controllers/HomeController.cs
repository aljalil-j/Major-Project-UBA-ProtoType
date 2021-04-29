using Major_Project_UBA_ProtoType.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Major_Project_UBA_ProtoType.Controllers
{
   
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Admins()
        {
            return View();
        }

        public IActionResult data()
        {
            return View();
        }

        public IActionResult cases()
        {
            return View();
        }

        public IActionResult settings()
        {
            return View();
        }

        public IActionResult modeling()
        {
            return View();
        }

        public IActionResult anamolies()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
