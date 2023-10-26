using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestEvolutiaWorker.Infraestructure.Data;
using TestEvolutiaWorker.Infraestructure.Entities;

namespace EvorodApp.Controllers
{
    public class DeviceController
    {
        private readonly DataContext _context;

        public DeviceController(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Device>> GetDeviceAsync()
        {
            try
            {
                return await _context.Devices
                                          .AsNoTracking()
                                          .ToListAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<Device> Details(int? id)
        {
            if (id == null)
            {
                return null;
            }

            var Device = await _context.Devices.AsNoTracking().FirstOrDefaultAsync(g => g.Id == id);
            if (@Device == null)
            {
                return null;
            }

            return @Device;
        }

        public async Task<bool> Create(Device @Device)
        {
            _context.Add(@Device);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Edit(int id, Device @Device)
        {
            if (id != @Device.Id)
            {
                return false;
            }

            try
            {
                var existingDevice = await _context.Devices
                    .Where(g => g.Id == id)
                    .FirstOrDefaultAsync();

                if (existingDevice != null)
                {
                    //existingDevice.Name = @Device.Name;
                    existingDevice.Note = @Device.Note;

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
                if (!DeviceExists(@Device.Id))
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
            var @Device = await _context.Devices.FindAsync(id);
            _context.Devices.Remove(@Device);
            await _context.SaveChangesAsync();
            return true;
        }

        private bool DeviceExists(int id)
        {
            return _context.Devices.Any(e => e.Id == id);
        }
    }
}
