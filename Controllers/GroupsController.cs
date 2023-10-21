using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TestEvolutiaWorker.Infraestructure.Entities;
using TestEvolutiaWorker.Infraestructure.Data;
using System.Reflection.Metadata.Ecma335;

namespace EvorodApp.Controllers
{
    public class GroupsController
    {
        private readonly DataContext _context;

        public GroupsController(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Group>> GetGroupsAsync()
        {
            var dara = from c in _context.Groups
                    select c;
            var data = dara.ToList();
            return data;
        }

        // GET: Groups
        //public async Task<IActionResult> Index(
        //    string sortOrder,
        //    string currentFilter,
        //    string searchString,
        //    int? pageNumber)
        //{
        //    ViewData["CurrentSort"] = sortOrder;
        //    ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";

        //    if (searchString != null)
        //    {
        //        pageNumber = 1;
        //    }
        //    else
        //    {
        //        searchString = currentFilter;
        //    }

        //    ViewData["CurrentFilter"] = searchString;

        //    var groups = from g in _context.Group
        //                 select g;

        //    if (!String.IsNullOrEmpty(searchString))
        //    {
        //        groups = groups.Where(g => g.Name.Contains(searchString) || g.Note.Contains(searchString));
        //    }

        //    switch (sortOrder)
        //    {
        //        case "name_desc":
        //            groups = groups.OrderByDescending(g => g.Name);
        //            break;
        //        default:
        //            groups = groups.OrderBy(g => g.Name);
        //            break;
        //    }

        //    int pageSize = 10;
        //    return View(await PaginatedList<Group>.CreateAsync(groups.AsNoTracking(), pageNumber ?? 1, pageSize));
        //}

        //// GET: Groups/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var @group = await _context.Group
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (@group == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(@group);
        //}

        //// GET: Groups/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Groups/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,Name,Note")] Group @group)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(@group);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(@group);
        //}

        //// GET: Groups/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var @group = await _context.Group.FindAsync(id);
        //    if (@group == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(@group);
        //}

        //// POST: Groups/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Note")] Group @group)
        //{
        //    if (id != @group.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(@group);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!GroupExists(@group.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(@group);
        //}

        //// GET: Groups/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var @group = await _context.Group
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (@group == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(@group);
        //}

        //// POST: Groups/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var @group = await _context.Group.FindAsync(id);
        //    _context.Group.Remove(@group);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool GroupExists(int id)
        //{
        //    return _context.Group.Any(e => e.Id == id);
        //}
    }
}
