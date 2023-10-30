using Microsoft.EntityFrameworkCore;
using TestEvolutiaWorker.Infraestructure.Entities;
using TestEvolutiaWorker.Infraestructure.Data;

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
            try
            {
                return await _context.Groups
                                          .AsNoTracking()
                                          .ToListAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<Group> Details(int? id)
        {
            if (id == null)
            {
                return null;
            }

            var group = await _context.Groups.AsNoTracking().FirstOrDefaultAsync(g => g.Id == id);
            if (@group == null)
            {
                return null;
            }

            return @group;
        }

        public async Task<bool> Create(Group @group)
        {
            _context.Add(@group);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Edit(int id, Group @group)
        {
            if (id != @group.Id)
            {
                return false;
            }

            try
            {
                var existingGroup = await _context.Groups
                    .Where(g => g.Id == id)
                    .FirstOrDefaultAsync();

                if (existingGroup != null)
                {
                    existingGroup.Name = @group.Name;
                    existingGroup.Note = @group.Note;

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
                if (!GroupExists(@group.Id))
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
            var @group = await _context.Groups.FindAsync(id);
            _context.Groups.Remove(@group);
            await _context.SaveChangesAsync();
            return true;
        }

        private bool GroupExists(int id)
        {
            return _context.Groups.Any(e => e.Id == id);
        }
    }
}
