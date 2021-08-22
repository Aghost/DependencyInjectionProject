using DependancyInjectionProject.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DependancyInjectionProject.Data {
    public class DependancyInjectionProjectDbContext : DbContext {
        //public DependancyInjectionProjectDbContext() { }
        public DependancyInjectionProjectDbContext(DbContextOptions options) : base(options) { }

        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
    }
}
