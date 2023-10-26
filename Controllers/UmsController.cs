using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestEvolutiaWorker.Infraestructure.Data;
using TestEvolutiaWorker.Infraestructure.Entities;

namespace EvorodApp.Controllers
{
    public class UmController
    {
        private readonly DataContext _context;

        public UmController(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Um>> GetUmAsync()
        {
            try
            {
                return await _context.Ums
                                          .AsNoTracking()
                                          .ToListAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<Um> Details(int? id)
        {
            if (id == null)
            {
                return null;
            }

            var Um = await _context.Ums.AsNoTracking().FirstOrDefaultAsync(g => g.Id == id);
            if (@Um == null)
            {
                return null;
            }

            return @Um;
        }

        public async Task<bool> Create(Um @Um)
        {
            _context.Add(@Um);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Edit(int id, Um @Um)
        {
            if (id != @Um.Id)
            {
                return false;
            }

            try
            {
                var existingUm = await _context.Ums
                    .Where(g => g.Id == id)
                    .FirstOrDefaultAsync();

                if (existingUm != null)
                {
                    //existingUm.Name = @Um.Name;
                    existingUm.Note = @Um.Note;

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
                if (!UmExists(@Um.Id))
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
            var @Um = await _context.Ums.FindAsync(id);
            _context.Ums.Remove(@Um);
            await _context.SaveChangesAsync();
            return true;
        }

        private bool UmExists(int id)
        {
            return _context.Ums.Any(e => e.Id == id);
        }
    }
}
