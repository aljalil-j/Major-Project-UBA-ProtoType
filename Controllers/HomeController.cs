using Major_Project_UBA_ProtoType.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Major_Project_UBA_ProtoType.Data;
using Microsoft.EntityFrameworkCore;

namespace Major_Project_UBA_ProtoType.Controllers
{
   
    public class HomeController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly ApplicationDbContext _context2;
        //private readonly UserManager<Customer> userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public HomeController(ApplicationDbContext context,  IHttpContextAccessor httpContextAccessor,
           ApplicationDbContext context2)
        {
            _context = context;
           // this.userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
            _context2 = context2;
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

        /* public async Task<IActionResult> data()
         {
             return View(await _context.Data.ToListAsync());
         }*/

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
