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
//    public class UrmsController : Controller
//    {
//        private readonly ApplicationDbContext _context;

//        public UrmsController(ApplicationDbContext context)
//        {
//            _context = context;
//        }

//        // GET: Urms
//        public async Task<IActionResult> Index(
//            string sortOrder,
//            string currentFilter,
//            string searchString,
//            int? pageNumber)
//        {
//            ViewData["CurrentSort"] = sortOrder;
//            ViewData["NumberSortParm"] = String.IsNullOrEmpty(sortOrder) ? "number_desc" : "number";
//            ViewData["BrandSortParm"] = String.IsNullOrEmpty(sortOrder) ? "brand_desc" : "brand";
//            // You can add more sort parameters as needed

//            if (searchString != null)
//            {
//                pageNumber = 1;
//            }
//            else
//            {
//                searchString = currentFilter;
//            }

//            ViewData["CurrentFilter"] = searchString;

//            var urms = from u in _context.Urm.Include(u => u.Device)
//                       select u;

//            if (!String.IsNullOrEmpty(searchString))
//            {
//                urms = urms.Where(u => u.Brand.Contains(searchString) ||
//                                       u.Contact.Contains(searchString) ||
//                                       u.Phone.Contains(searchString) ||
//                                       u.Email.Contains(searchString) ||
//                                       u.User.Contains(searchString) ||
//                                       u.Password.Contains(searchString) ||
//                                       u.Note.Contains(searchString));
//                // You can add more search conditions as needed
//            }

//            switch (sortOrder)
//            {
//                case "number":
//                    urms = urms.OrderBy(u => u.Number);
//                    break;
//                case "number_desc":
//                    urms = urms.OrderByDescending(u => u.Number);
//                    break;
//                case "brand":
//                    urms = urms.OrderBy(u => u.Brand);
//                    break;
//                case "brand_desc":
//                    urms = urms.OrderByDescending(u => u.Brand);
//                    break;
//                // You can add more sorting cases as needed
//                default:
//                    urms = urms.OrderBy(u => u.Id);
//                    break;
//            }

//            int pageSize = 10;
//            return View(await PaginatedList<Urm>.CreateAsync(urms.AsNoTracking(), pageNumber ?? 1, pageSize));
//        }


//        // GET: Urms/Details/5
//        public async Task<IActionResult> Details(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var urm = await _context.Urm
//                .Include(u => u.Device)
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (urm == null)
//            {
//                return NotFound();
//            }

//            return View(urm);
//        }

//        // GET: Urms/Create
//        public IActionResult Create()
//        {
//            ViewData["DeviceId"] = new SelectList(_context.Device, "Id", "Brand");
//            return View();
//        }

//        // POST: Urms/Create
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Create([Bind("Id,DeviceId,Number,Brand,ClosingHour,Contact,Phone,Email,User,Password,VpnIP,VpnPort,DataLoggerIp,Note")] Urm urm)
//        {
//            if (ModelState.IsValid)
//            {
//                _context.Add(urm);
//                await _context.SaveChangesAsync();
//                return RedirectToAction(nameof(Index));
//            }
//            ViewData["DeviceId"] = new SelectList(_context.Device, "Id", "Brand", urm.DeviceId);
//            return View(urm);
//        }

//        // GET: Urms/Edit/5
//        public async Task<IActionResult> Edit(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var urm = await _context.Urm.FindAsync(id);
//            if (urm == null)
//            {
//                return NotFound();
//            }
//            ViewData["DeviceId"] = new SelectList(_context.Device, "Id", "Brand", urm.DeviceId);
//            return View(urm);
//        }

//        // POST: Urms/Edit/5
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Edit(int id, [Bind("Id,DeviceId,Number,Brand,ClosingHour,Contact,Phone,Email,User,Password,VpnIP,VpnPort,DataLoggerIp,Note")] Urm urm)
//        {
//            if (id != urm.Id)
//            {
//                return NotFound();
//            }

//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    _context.Update(urm);
//                    await _context.SaveChangesAsync();
//                }
//                catch (DbUpdateConcurrencyException)
//                {
//                    if (!UrmExists(urm.Id))
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
//            ViewData["DeviceId"] = new SelectList(_context.Device, "Id", "Brand", urm.DeviceId);
//            return View(urm);
//        }

//        // GET: Urms/Delete/5
//        public async Task<IActionResult> Delete(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var urm = await _context.Urm
//                .Include(u => u.Device)
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (urm == null)
//            {
//                return NotFound();
//            }

//            return View(urm);
//        }

//        // POST: Urms/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(int id)
//        {
//            var urm = await _context.Urm.FindAsync(id);
//            _context.Urm.Remove(urm);
//            await _context.SaveChangesAsync();
//            return RedirectToAction(nameof(Index));
//        }

//        private bool UrmExists(int id)
//        {
//            return _context.Urm.Any(e => e.Id == id);
//        }
//    }
//}
