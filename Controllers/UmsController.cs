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
//    public class UmsController : Controller
//    {
//        private readonly ApplicationDbContext _context;

//        public UmsController(ApplicationDbContext context)
//        {
//            _context = context;
//        }

//        // GET: Ums
//        public async Task<IActionResult> Index(
//            string sortOrder,
//            string currentFilter,
//            string searchString,
//            int? pageNumber)
//        {
//            ViewData["CurrentSort"] = sortOrder;
//            ViewData["UmUrmSortParm"] = String.IsNullOrEmpty(sortOrder) ? "um_urm_desc" : "um_urm";
//            ViewData["UmSetSortParm"] = String.IsNullOrEmpty(sortOrder) ? "um_set_desc" : "um_set";
//            // Agrega más campos según lo necesites

//            if (searchString != null)
//            {
//                pageNumber = 1;
//            }
//            else
//            {
//                searchString = currentFilter;
//            }

//            ViewData["CurrentFilter"] = searchString;

//            var ums = from u in _context.Um.Include(u => u.Urm).Include(u => u.Cups)
//                      select u;

//            if (!String.IsNullOrEmpty(searchString))
//            {
//                ums = ums.Where(u => u.Note.Contains(searchString) ||
//                                     u.Usuario.Contains(searchString) ||
//                                     u.Contraseña.Contains(searchString) ||
//                                     u.Url.Contains(searchString));
//                // Puedes añadir más campos según los necesites
//            }

//            switch (sortOrder)
//            {
//                case "um_urm":
//                    ums = ums.OrderBy(u => u.Um_Urm);
//                    break;
//                case "um_urm_desc":
//                    ums = ums.OrderByDescending(u => u.Um_Urm);
//                    break;
//                case "um_set":
//                    ums = ums.OrderBy(u => u.Um_Set);
//                    break;
//                case "um_set_desc":
//                    ums = ums.OrderByDescending(u => u.Um_Set);
//                    break;
//                // Añade más casos según los necesites
//                default:
//                    ums = ums.OrderBy(u => u.Id);
//                    break;
//            }

//            int pageSize = 10;
//            return View(await PaginatedList<Um>.CreateAsync(ums.AsNoTracking(), pageNumber ?? 1, pageSize));
//        }


//        // GET: Ums/Details/5
//        public async Task<IActionResult> Details(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var um = await _context.Um
//                .Include(u => u.Cups)
//                .Include(u => u.Urm)
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (um == null)
//            {
//                return NotFound();
//            }

//            return View(um);
//        }

//        // GET: Ums/Create
//        public IActionResult Create()
//        {
//            ViewData["CupsId"] = new SelectList(_context.Cup, "Id", "CupsCode");
//            ViewData["UrmId"] = new SelectList(_context.Set<Urm>(), "Id", "Number");
//            return View();
//        }

//        // POST: Ums/Create
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Create([Bind("Id,UrmId,CupsId,Um_Urm,Um_Set,Note")] Um um)
//        {
//            if (ModelState.IsValid)
//            {
//                _context.Add(um);
//                await _context.SaveChangesAsync();
//                return RedirectToAction(nameof(Index));
//            }
//            ViewData["CupsId"] = new SelectList(_context.Cup, "Id", "CupsCode", um.CupsId);
//            ViewData["UrmId"] = new SelectList(_context.Set<Urm>(), "Id", "Brand", um.UrmId);
//            return View(um);
//        }

//        // GET: Ums/Edit/5
//        public async Task<IActionResult> Edit(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var um = await _context.Um.FindAsync(id);
//            if (um == null)
//            {
//                return NotFound();
//            }
//            ViewData["CupsId"] = new SelectList(_context.Cup, "Id", "CupsCode", um.CupsId);
//            ViewData["UrmId"] = new SelectList(_context.Set<Urm>(), "Id", "Brand", um.UrmId);
//            return View(um);
//        }

//        // POST: Ums/Edit/5
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Edit(int id, [Bind("Id,UrmId,CupsId,Um_Urm,Um_Set,Note")] Um um)
//        {
//            if (id != um.Id)
//            {
//                return NotFound();
//            }

//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    _context.Update(um);
//                    await _context.SaveChangesAsync();
//                }
//                catch (DbUpdateConcurrencyException)
//                {
//                    if (!UmExists(um.Id))
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
//            ViewData["CupsId"] = new SelectList(_context.Cup, "Id", "CupsCode", um.CupsId);
//            ViewData["UrmId"] = new SelectList(_context.Set<Urm>(), "Id", "Brand", um.UrmId);
//            return View(um);
//        }

//        // GET: Ums/Delete/5
//        public async Task<IActionResult> Delete(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var um = await _context.Um
//                .Include(u => u.Cups)
//                .Include(u => u.Urm)
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (um == null)
//            {
//                return NotFound();
//            }

//            return View(um);
//        }

//        // POST: Ums/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(int id)
//        {
//            var um = await _context.Um.FindAsync(id);
//            _context.Um.Remove(um);
//            await _context.SaveChangesAsync();
//            return RedirectToAction(nameof(Index));
//        }

//        private bool UmExists(int id)
//        {
//            return _context.Um.Any(e => e.Id == id);
//        }
//    }
//}
