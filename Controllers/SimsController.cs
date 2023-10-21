//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.EntityFrameworkCore;
//using EvorodApp.Data;
//using EvorodApp.Models;
//using EvorodApp.Utils;
//using System;

//namespace EvorodApp.Controllers
//{
//    public class SimsController : Controller
//    {
//        private readonly ApplicationDbContext _context;

//        public SimsController(ApplicationDbContext context)
//        {
//            _context = context;
//        }

//        // GET: Sims
//        public async Task<IActionResult> Index(
//            string sortOrder,
//            string currentFilter,
//            string searchString,
//            int? pageNumber)
//        {
//            ViewData["CurrentSort"] = sortOrder;
//            ViewData["NumberSortParm"] = String.IsNullOrEmpty(sortOrder) ? "number_desc" : "";
//            ViewData["PhoneSortParm"] = sortOrder == "Phone" ? "phone_desc" : "Phone";
//            ViewData["OperatorSortParm"] = sortOrder == "Operator" ? "operator_desc" : "Operator";

//            if (searchString != null)
//            {
//                pageNumber = 1;
//            }
//            else
//            {
//                searchString = currentFilter;
//            }

//            ViewData["CurrentFilter"] = searchString;

//            var sims = from s in _context.Sim.Include(c => c.ContractType)
//                       select s;

//            if (!String.IsNullOrEmpty(searchString))
//            {
//                sims = sims.Where(s => s.Number.Contains(searchString)
//                                || s.Phone.Contains(searchString)
//                                || s.Operator.Contains(searchString)
//                                || s.Note.Contains(searchString));
//            }

//            switch (sortOrder)
//            {
//                case "number_desc":
//                    sims = sims.OrderByDescending(s => s.Number);
//                    break;
//                case "Phone":
//                    sims = sims.OrderBy(s => s.Phone);
//                    break;
//                case "phone_desc":
//                    sims = sims.OrderByDescending(s => s.Phone);
//                    break;
//                case "Operator":
//                    sims = sims.OrderBy(s => s.Operator);
//                    break;
//                case "operator_desc":
//                    sims = sims.OrderByDescending(s => s.Operator);
//                    break;
//                default:
//                    sims = sims.OrderBy(s => s.Number);
//                    break;
//            }

//            int pageSize = 10;
//            return View(await PaginatedList<Sim>.CreateAsync(sims.AsNoTracking(), pageNumber ?? 1, pageSize));
//        }


//        // GET: Sims/Details/5
//        public async Task<IActionResult> Details(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var sim = await _context.Sim
//                .Include(s => s.ContractType)
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (sim == null)
//            {
//                return NotFound();
//            }

//            return View(sim);
//        }

//        // GET: Sims/Create
//        public IActionResult Create()
//        {
//            ViewData["IdContract"] = new SelectList(_context.ContractType, "Id", "Detail");
//            return View();
//        }

//        // POST: Sims/Create
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Create([Bind("Id,Number,Phone,Operator,IdContract,Note")] Sim sim)
//        {
//            if (ModelState.IsValid)
//            {
//                _context.Add(sim);
//                await _context.SaveChangesAsync();
//                return RedirectToAction(nameof(Index));
//            }
//            ViewData["IdContract"] = new SelectList(_context.ContractType, "Id", "Detail", sim.IdContract);
//            return View(sim);
//        }

//        // GET: Sims/Edit/5
//        public async Task<IActionResult> Edit(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var sim = await _context.Sim.FindAsync(id);
//            if (sim == null)
//            {
//                return NotFound();
//            }
//            ViewData["IdContract"] = new SelectList(_context.ContractType, "Id", "Detail", sim.IdContract);
//            return View(sim);
//        }

//        // POST: Sims/Edit/5
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Edit(int id, [Bind("Id,Number,Phone,Operator,IdContract,Note")] Sim sim)
//        {
//            if (id != sim.Id)
//            {
//                return NotFound();
//            }

//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    _context.Update(sim);
//                    await _context.SaveChangesAsync();
//                }
//                catch (DbUpdateConcurrencyException)
//                {
//                    if (!SimExists(sim.Id))
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
//            ViewData["IdContract"] = new SelectList(_context.ContractType, "Id", "Detail", sim.IdContract);
//            return View(sim);
//        }

//        // GET: Sims/Delete/5
//        public async Task<IActionResult> Delete(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var sim = await _context.Sim
//                .Include(s => s.ContractType)
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (sim == null)
//            {
//                return NotFound();
//            }

//            return View(sim);
//        }

//        // POST: Sims/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(int id)
//        {
//            var sim = await _context.Sim.FindAsync(id);
//            _context.Sim.Remove(sim);
//            await _context.SaveChangesAsync();
//            return RedirectToAction(nameof(Index));
//        }

//        private bool SimExists(int id)
//        {
//            return _context.Sim.Any(e => e.Id == id);
//        }
//    }
//}
