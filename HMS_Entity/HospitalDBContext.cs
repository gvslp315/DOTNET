using System.Reflection;
using Microsoft.EntityFrameworkCore;
using HMS_Entity.Models;

namespace HMS_Entity
{
    public class HospitalDBContext : DbContext
    {
        public DbSet<Hospital> Hospitals { get; set; }

        public HospitalDBContext(DbContextOptions<HospitalDBContext> options)
     : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=postgres;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<HMS_Entity.Models.Hospital> Hospital { get; set; } = default!;


    }
}
