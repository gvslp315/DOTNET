using System.Reflection;
using Microsoft.EntityFrameworkCore;
using HMS_Entity.Models;

namespace HMS_Entity
{
    public class HospitalDBContext : DbContext
    {
        public required DbSet<Hospital> Hospital { get; set; }

        public required DbSet<Medical> Medical { get; set; }

        public HospitalDBContext(DbContextOptions<HospitalDBContext> options)
     : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=HMS;Username=postgres;Password=postgres;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
        //public DbSet<HMS_Entity.Models.Hospital> Hospital { get; set; } = default!;
        //public DbSet<HMS_Entity.Models.Medical> Medical { get; set; } = default!;


    }
}
