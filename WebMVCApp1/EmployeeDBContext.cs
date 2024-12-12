using System.ComponentModel.DataAnnotations;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using WebMVCApp1.Models;

namespace WebMVCApp1
{
    public class EmployeeDBContext : DbContext
    {
        public DbSet<Employee>? Employees { get; set; }

        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options)
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


    }
}
