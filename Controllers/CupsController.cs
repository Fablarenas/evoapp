//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.EntityFrameworkCore;
//using EvorodApp.Data;
//using EvorodApp.Models;
//using EvorodApp.Utils;

//namespace EvorodApp.Controllers
//{
//    public class CupsController : Controller
//    {
//        private readonly ApplicationDbContext _context;

//        public CupsController(ApplicationDbContext context)
//        {
//            _context = context;
//        }

//        // GET: Cups
//        public async Task<IActionResult> Index(
//                    string sortOrder,
//                    string currentFilter,
//                    string searchString,
//                    int? pageNumber)
//        {
//            ViewData["CurrentSort"] = sortOrder;
//            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";

//            if (searchString != null)
//            {
//                pageNumber = 1;
//            }
//            else
//            {
//                searchString = currentFilter;
//            }

//            ViewData["CurrentFilter"] = searchString;

//            var cups = from c in _context.Cup.Include(c => c.Client)
//                       select c;

//            if (!String.IsNullOrEmpty(searchString))
//            {
//                cups = cups.Where(c => c.CupsCode.Contains(searchString) || c.Note.Contains(searchString));
//            }

//            switch (sortOrder)
//            {
//                case "name_desc":
//                    cups = cups.OrderByDescending(c => c.CupsCode);
//                    break;
//                default:
//                    cups = cups.OrderBy(c => c.CupsCode);
//                    break;
//            }

//            int pageSize = 10;
//            return View(await PaginatedList<Cups>.CreateAsync(cups.AsNoTracking(), pageNumber ?? 1, pageSize));
//        }


//        // GET: Cups/Details/5
//        public async Task<IActionResult> Details(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var cups = await _context.Cup
//                .Include(c => c.Client)
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (cups == null)
//            {
//                return NotFound();
//            }

//            return View(cups);
//        }

//        // GET: Cups/Create
//        public IActionResult Create()
//        {
//            ViewData["IdClient"] = new SelectList(_context.Client, "Id", "CIF");
//            return View();
//        }

//        // POST: Cups/Create
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Create([Bind("Id,IdClient,CupsCode,Supply,Priority,Auto,FrameActv,HourlyActv,DailyActv,LogActv,Note")] Cups cups)
//        {
//            if (ModelState.IsValid)
//            {
//                _context.Add(cups);
//                await _context.SaveChangesAsync();
//                return RedirectToAction(nameof(Index));
//            }
//            ViewData["IdClient"] = new SelectList(_context.Client, "Id", "CIF", cups.IdClient);
//            return View(cups);
//        }

//        // GET: Cups/Edit/5
//        public async Task<IActionResult> Edit(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var cups = await _context.Cup.FindAsync(id);
//            if (cups == null)
//            {
//                return NotFound();
//            }
//            ViewData["IdClient"] = new SelectList(_context.Client, "Id", "CIF", cups.IdClient);
//            return View(cups);
//        }

//        // POST: Cups/Edit/5
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Edit(int id, [Bind("Id,IdClient,CupsCode,Supply,Priority,Auto,FrameActv,HourlyActv,DailyActv,LogActv,Note")] Cups cups)
//        {
//            if (id != cups.Id)
//            {
//                return NotFound();
//            }

//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    _context.Update(cups);
//                    await _context.SaveChangesAsync();
//                }
//                catch (DbUpdateConcurrencyException)
//                {
//                    if (!CupsExists(cups.Id))
//                    {
//                        return NotFound();
//                    }
//                    else
//                    {
//                        throw;
//                    }
//                }
//                return RedirectToAction(nameof(Index));
//            }
//            ViewData["IdClient"] = new SelectList(_context.Client, "Id", "CIF", cups.IdClient);
//            return View(cups);
//        }

//        // GET: Cups/Delete/5
//        public async Task<IActionResult> Delete(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var cups = await _context.Cup
//                .Include(c => c.Client)
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (cups == null)
//            {
//                return NotFound();
//            }

//            return View(cups);
//        }

//        // POST: Cups/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(int id)
//        {
//            var cups = await _context.Cup.FindAsync(id);
//            _context.Cup.Remove(cups);
//            await _context.SaveChangesAsync();
//            return RedirectToAction(nameof(Index));
//        }

//        private bool CupsExists(int id)
//        {
//            return _context.Cup.Any(e => e.Id == id);
//        }
//    }
//}
