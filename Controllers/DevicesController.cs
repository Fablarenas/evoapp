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
//    public class DevicesController : Controller
//    {
//        private readonly ApplicationDbContext _context;

//        //public DevicesController(ApplicationDbContext context)
//        {
//            _context = context;
//        }

//        // GET: Devices
//        public async Task<IActionResult> Index(
//            string sortOrder,
//            string currentFilter,
//            string searchString,
//            int? pageNumber)
//        {
//            ViewData["CurrentSort"] = sortOrder;
//            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
//            ViewData["BrandSortParm"] = String.IsNullOrEmpty(sortOrder) ? "brand_desc" : "brand";
//            ViewData["ModelSortParm"] = String.IsNullOrEmpty(sortOrder) ? "model_desc" : "model";

//            if (searchString != null)
//            {
//                pageNumber = 1;
//            }
//            else
//            {
//                searchString = currentFilter;
//            }

//            ViewData["CurrentFilter"] = searchString;

//            var devices = from d in _context.Device.Include(d => d.Sim)
//                          select d;

//            if (!String.IsNullOrEmpty(searchString))
//            {
//                devices = devices.Where(d => d.Name.Contains(searchString) ||
//                                             d.Brand.Contains(searchString) ||
//                                             d.Model.Contains(searchString) ||
//                                             d.Note.Contains(searchString));
//            }

//            switch (sortOrder)
//            {
//                case "name_desc":
//                    devices = devices.OrderByDescending(d => d.Name);
//                    break;
//                case "brand":
//                    devices = devices.OrderBy(d => d.Brand);
//                    break;
//                case "brand_desc":
//                    devices = devices.OrderByDescending(d => d.Brand);
//                    break;
//                case "model":
//                    devices = devices.OrderBy(d => d.Model);
//                    break;
//                case "model_desc":
//                    devices = devices.OrderByDescending(d => d.Model);
//                    break;
//                default:
//                    devices = devices.OrderBy(d => d.Name);
//                    break;
//            }

//            int pageSize = 10;
//            return View(await PaginatedList<Device>.CreateAsync(devices.AsNoTracking(), pageNumber ?? 1, pageSize));
//        }


//        // GET: Devices/Details/5
//        public async Task<IActionResult> Details(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var device = await _context.Device
//                .Include(d => d.Sim)
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (device == null)
//            {
//                return NotFound();
//            }

//            return View(device);
//        }

//        // GET: Devices/Create
//        public IActionResult Create()
//        {
//            ViewData["IdSim"] = new SelectList(_context.Sim, "Id", "Number");
//            return View();
//        }

//        // POST: Devices/Create
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Create([Bind("Id,IdSim,Name,Brand,Model,Serial,RouterIp,RouterPort,User,Password,Note")] Device device)
//        {
//            if (ModelState.IsValid)
//            {
//                _context.Add(device);
//                await _context.SaveChangesAsync();
//                return RedirectToAction(nameof(Index));
//            }
//            ViewData["IdSim"] = new SelectList(_context.Sim, "Id", "Number", device.IdSim);
//            return View(device);
//        }

//        // GET: Devices/Edit/5
//        public async Task<IActionResult> Edit(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var device = await _context.Device.FindAsync(id);
//            if (device == null)
//            {
//                return NotFound();
//            }
//            ViewData["IdSim"] = new SelectList(_context.Sim, "Id", "Number", device.IdSim);
//            return View(device);
//        }

//        // POST: Devices/Edit/5
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Edit(int id, [Bind("Id,IdSim,Name,Brand,Model,Serial,RouterIp,RouterPort,User,Password,Note")] Device device)
//        {
//            if (id != device.Id)
//            {
//                return NotFound();
//            }

//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    _context.Update(device);
//                    await _context.SaveChangesAsync();
//                }
//                catch (DbUpdateConcurrencyException)
//                {
//                    if (!DeviceExists(device.Id))
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
//            ViewData["IdSim"] = new SelectList(_context.Sim, "Id", "Number", device.IdSim);
//            return View(device);
//        }

//        // GET: Devices/Delete/5
//        public async Task<IActionResult> Delete(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var device = await _context.Device
//                .Include(d => d.Sim)
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (device == null)
//            {
//                return NotFound();
//            }

//            return View(device);
//        }

//        // POST: Devices/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(int id)
//        {
//            var device = await _context.Device.FindAsync(id);
//            _context.Device.Remove(device);
//            await _context.SaveChangesAsync();
//            return RedirectToAction(nameof(Index));
//        }

//        private bool DeviceExists(int id)
//        {
//            return _context.Device.Any(e => e.Id == id);
//        }
//    }
//}
