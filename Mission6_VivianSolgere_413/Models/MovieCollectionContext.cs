using Microsoft.EntityFrameworkCore;

namespace Mission6_VivianSolgere_413.Models
{
    public class MovieCollectionContext : DbContext
    {
        public MovieCollectionContext(DbContextOptions<MovieCollectionContext> options) : base(options) { }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) //Seed data
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Family" },
                new Category { CategoryId = 2, CategoryName = "Comedy" },
                new Category { CategoryId = 3, CategoryName = "Religious" },
                new Category { CategoryId = 4, CategoryName = "RomCom" },
                new Category { CategoryId = 5, CategoryName = "Chick Flick" },
                new Category { CategoryId = 6, CategoryName = "Horror" }
            );  
        }
    }
}
