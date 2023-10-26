using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestEvolutiaWorker.Infraestructure.Data;
using TestEvolutiaWorker.Infraestructure.Entities;

namespace EvorodApp.Controllers
{
    public class SimController
    {
        private readonly DataContext _context;

        public SimController(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Sim>> GetSimAsync()
        {
            try
            {
                return await _context.Sims
                                          .AsNoTracking()
                                          .ToListAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<Sim> Details(int? id)
        {
            if (id == null)
            {
                return null;
            }

            var Sim = await _context.Sims.AsNoTracking().FirstOrDefaultAsync(g => g.Id == id);
            if (@Sim == null)
            {
                return null;
            }

            return @Sim;
        }

        public async Task<bool> Create(Sim @Sim)
        {
            _context.Add(@Sim);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Edit(int id, Sim @Sim)
        {
            if (id != @Sim.Id)
            {
                return false;
            }

            try
            {
                var existingSim = await _context.Sims
                    .Where(g => g.Id == id)
                    .FirstOrDefaultAsync();

                if (existingSim != null)
                {
                    //existingSim.Name = @Sim.Name;
                    existingSim.Note = @Sim.Note;

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
                if (!SimExists(@Sim.Id))
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
            var @Sim = await _context.Sims.FindAsync(id);
            _context.Sims.Remove(@Sim);
            await _context.SaveChangesAsync();
            return true;
        }

        private bool SimExists(int id)
        {
            return _context.Sims.Any(e => e.Id == id);
        }
    }
}
