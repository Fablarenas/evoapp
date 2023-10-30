using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestEvolutiaWorker.Infraestructure.Data;
using TestEvolutiaWorker.Infraestructure.Entities;

namespace EvorodApp.Controllers
{
    public class CupsController
    {
        private readonly DataContext _context;

        public CupsController(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<object>> GetCupsAsync()
        {
            try
            {
                return await _context.Cups
                                     .Include(c => c.Client) // Asegúrese de que Group está correctamente configurado en su modelo
                                     .Select(c => new
                                     {
                                         c.Id,
                                         c.CupsCode,
                                         c.Note,
                                         ClientName = c.Client.Name // Asumiendo que la relación está correctamente configurada
                                     })
                                     .AsNoTracking()
                                     .ToListAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<Cups> Details(int? id)
        {
            if (id == null)
            {
                return null;
            }

            var Cups = await _context.Cups.AsNoTracking().FirstOrDefaultAsync(g => g.Id == id);
            if (@Cups == null)
            {
                return null;
            }

            return @Cups;
        }

        public async Task<bool> Create(Cups @Cups)
        {
            _context.Add(@Cups);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Edit(int id, Cups @Cups)
        {
            if (id != @Cups.Id)
            {
                return false;
            }

            try
            {
                var existingCups = await _context.Cups
                    .Where(g => g.Id == id)
                    .FirstOrDefaultAsync();

                if (existingCups != null)
                {
                    //existingCups.Name = @Cups.Name;
                    existingCups.Note = @Cups.Note;

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
                if (!CupsExists(@Cups.Id))
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
            var @Cups = await _context.Cups.FindAsync(id);
            _context.Cups.Remove(@Cups);
            await _context.SaveChangesAsync();
            return true;
        }

        private bool CupsExists(int id)
        {
            return _context.Cups.Any(e => e.Id == id);
        }
    }
}
