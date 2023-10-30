using Microsoft.EntityFrameworkCore;
using TestEvolutiaWorker.Infraestructure.Data;
using TestEvolutiaWorker.Infraestructure.Entities;

namespace EvorodApp.Controllers
{
    public class ClientsController
    {
        private readonly DataContext _context;

        public ClientsController(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<object>> GetClientsAsync()
        {
            try
            {
                return await _context.Clients
                                     .Include(c => c.Group) // Asegúrese de que Group está correctamente configurado en su modelo
                                     .Select(c => new
                                     {
                                         c.Id,
                                         c.Name,
                                         c.CIF,
                                         c.Note,
                                         GroupName = c.Group.Name // Asumiendo que la relación está correctamente configurada
                                     })
                                     .AsNoTracking()
                                     .ToListAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<Client> Details(int? id)
        {
            if (id == null)
            {
                return null;
            }

            var Client = await _context.Clients.AsNoTracking().FirstOrDefaultAsync(g => g.Id == id);
            if (@Client == null)
            {
                return null;
            }

            return @Client;
        }

        public async Task<bool> Create(Client @Client)
        {
            _context.Add(@Client);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Edit(int id, Client @Client)
        {
            if (id != @Client.Id)
            {
                return false;
            }

            try
            {
                var existingClient = await _context.Clients
                    .Where(g => g.Id == id)
                    .FirstOrDefaultAsync();

                if (existingClient != null)
                {
                    existingClient.Name = @Client.Name;
                    existingClient.Note = @Client.Note;

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
                if (!ClientExists(@Client.Id))
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
            var @Client = await _context.Clients.FindAsync(id);
            _context.Clients.Remove(@Client);
            await _context.SaveChangesAsync();
            return true;
        }

        private bool ClientExists(int id)
        {
            return _context.Clients.Any(e => e.Id == id);
        }
    }
}
