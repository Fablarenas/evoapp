using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestEvolutiaWorker.Infraestructure.Data;
using TestEvolutiaWorker.Infraestructure.Entities;

namespace EvorodApp.Controllers
{
    public class ContractController
    {
        private readonly DataContext _context;

        public ContractController(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ContractType>> GetContractAsync()
        {
            try
            {
                return await _context.ContractTypes
                                          .AsNoTracking()
                                          .ToListAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<ContractType> Details(int? id)
        {
            if (id == null)
            {
                return null;
            }

            var Contract = await _context.ContractTypes.AsNoTracking().FirstOrDefaultAsync(g => g.Id == id);
            if (@Contract == null)
            {
                return null;
            }

            return @Contract;
        }

        public async Task<bool> Create(ContractType @Contract)
        {
            _context.Add(@Contract);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Edit(int id, ContractType @Contract)
        {
            if (id != @Contract.Id)
            {
                return false;
            }

            try
            {
                var existingContract = await _context.ContractTypes
                    .Where(g => g.Id == id)
                    .FirstOrDefaultAsync();

                if (existingContract != null)
                {
                    //existingContract.Name = @Contract.Name;
                    //existingContract.Note = @Contract.Note;

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
                if (!ContractExists(@Contract.Id))
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
            var @Contract = await _context.ContractTypes.FindAsync(id);
            _context.ContractTypes.Remove(@Contract);
            await _context.SaveChangesAsync();
            return true;
        }

        private bool ContractExists(int id)
        {
            return _context.ContractTypes.Any(e => e.Id == id);
        }
    }
}
