using System.Reflection;
using Microsoft.EntityFrameworkCore;
using MoviesAPI.Models;

namespace MoviesAPI
{
    public class MoviesDBContext : DbContext
    {
        public DbSet<Movies> Movies { get; set; }
        public MoviesDBContext(DbContextOptions<MoviesDBContext> options) : base(options)
        {
        }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Movies;Username=postgres;Password=postgres;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
