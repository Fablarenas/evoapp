using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestEvolutiaWorker.Infraestructure.Data;
using TestEvolutiaWorker.Infraestructure.Entities;

namespace EvorodApp.Controllers
{
    public class UrmController
    {
        private readonly DataContext _context;

        public UrmController(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Urm>> GetUrmAsync()
        {
            try
            {
                return await _context.Urms
                                          .AsNoTracking()
                                          .ToListAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<Urm> Details(int? id)
        {
            if (id == null)
            {
                return null;
            }

            var Urm = await _context.Urms.AsNoTracking().FirstOrDefaultAsync(g => g.Id == id);
            if (@Urm == null)
            {
                return null;
            }

            return @Urm;
        }

        public async Task<bool> Create(Urm @Urm)
        {
            _context.Add(@Urm);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Edit(int id, Urm @Urm)
        {
            if (id != @Urm.Id)
            {
                return false;
            }

            try
            {
                var existingUrm = await _context.Urms
                    .Where(g => g.Id == id)
                    .FirstOrDefaultAsync();

                if (existingUrm != null)
                {
                    //existingUrm.Name = @Urm.Name;
                    existingUrm.Note = @Urm.Note;

                    // Guardar los cambios
                    await _context.SaveChangesAsync();
                }
                else
                {
                    return false;
                }
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UrmExists(@Urm.Id))
                {
                    return false;
                }
                else
                {
                    throw;
                }
            }
            catch (Exception ex)
            {
            }

            return true;
        }

        public async Task<bool> DeleteConfirmed(int id)
        {
            var @Urm = await _context.Urms.FindAsync(id);
            _context.Urms.Remove(@Urm);
            await _context.SaveChangesAsync();
            return true;
        }

        private bool UrmExists(int id)
        {
            return _context.Urms.Any(e => e.Id == id);
        }
    }
}
