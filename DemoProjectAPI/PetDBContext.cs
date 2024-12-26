using Microsoft.EntityFrameworkCore;

namespace DemoProjectAPI
{
    public class PetDBContext : DbContext
    {
        public PetDBContext(DbContextOptions options):base(options) { }

        public DbSet<Models.PetAnimal> PetAnimals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=DemoProject;Username=postgres;Password=postgres;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
