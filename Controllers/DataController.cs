using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Major_Project_UBA_ProtoType.Data;
using Major_Project_UBA_ProtoType.Models;

namespace Major_Project_UBA_ProtoType.Controllers
{
    public class DataController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DataController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Data
        public async Task<IActionResult> Index()
        {
            return View(await _context.Data.ToListAsync());
        }

        // GET: Data/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @data = await _context.Data
                .FirstOrDefaultAsync(m => m.ID == id);
            if (@data == null)
            {
                return NotFound();
            }

            return View(@data);
        }

        // GET: Data/Create
        public IActionResult Create()
        {
            return View();
        }

        //i chnage data to dataController
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,User,IP_Address,Patterns,Location,Home_Address,History")] DataModel @data)
        {
            if (ModelState.IsValid)
            {
                _context.Add(@data);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(@data);
        }

        // GET: Data/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @data = await _context.Data.FindAsync(id);
            if (@data == null)
            {
                return NotFound();
            }
            return View(@data);
        }

        //i change data to datacontroller
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,User,IP_Address,Patterns,Location,Home_Address,History")] DataModel @data)
        {
            if (id != @data.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(@data);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DataExists(@data.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(@data);
        }

        // GET: Data/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @data = await _context.Data
                .FirstOrDefaultAsync(m => m.ID == id);
            if (@data == null)
            {
                return NotFound();
            }

            return View(@data);
        }

        // POST: Data/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var @data = await _context.Data.FindAsync(id);
            _context.Data.Remove(@data);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DataExists(int id)
        {
            return _context.Data.Any(e => e.ID == id);
        }
    }
}
