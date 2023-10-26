using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using TestEvolutiaWorker.Infraestructure.Entities;

namespace TestEvolutiaWorker.Infraestructure.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Cups> Cups { get; set; }
        public DbSet<Daily> Daily { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<Download> Downloads { get; set; }
        public DbSet<Frame> Frames { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Hourly> HourlyReadings { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<ReadCycle> ReadingCycles { get; set; }
        public DbSet<Sim> Sims { get; set; }
        public DbSet<Um> Ums { get; set; }
        public DbSet<Urm> Urms { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ContractType> ContractTypes { get; set; }

    }
}
