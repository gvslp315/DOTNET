using EMSDemoProject.Models;
using Microsoft.EntityFrameworkCore;

namespace EMSDemoProject
{
    public class EmsDBContext : DbContext
    {
        public EmsDBContext(DbContextOptions options) : base(options) { }  
        
        public DbSet<Employee> Employee {  get; set; }

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
