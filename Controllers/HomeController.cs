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
        private readonly IHttpContextAccessor _httpContextAccessor;

        public HomeController(ApplicationDbContext context,  IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
           
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

        // GET: Data/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @data = await _context.Transaction
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@data == null)
            {
                return NotFound();
            }

            return View(@data);
        }

        public async Task<IActionResult> data()   
         {
            
 
            return View(await _context.Transaction.ToListAsync());
        }

    public async Task<IActionResult>Transaction()
    {
            return View(await _context.ScotiaTransaction.ToListAsync());
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
