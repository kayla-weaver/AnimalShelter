using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace AnimalShelter.Models
{
    public class AppDbContext : DbContext
{
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Animal> Animals { get; set; }  
        public DbSet<Type> Types { get; set; }
    }
}

