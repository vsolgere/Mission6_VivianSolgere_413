using Microsoft.EntityFrameworkCore;

namespace Mission6_VivianSolgere_413.Models
{
    public class MovieCollectionContext : DbContext
    {
        public MovieCollectionContext(DbContextOptions<MovieCollectionContext> options) : base(options) { }

        public DbSet<Movie> Movies { get; set; }
    }
}
