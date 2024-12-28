using FinalProjectCsharp.Model;
using Microsoft.EntityFrameworkCore;

namespace FinalProjectCsharp
{
    public class PatientDBContext : DbContext
    {
        public DbSet <Patient> Patient { get; set; }

        public PatientDBContext(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=FinalProject;Username=postgres;Password=postgres;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


    }
}
