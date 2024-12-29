using Microsoft.EntityFrameworkCore;
using MovieApi.models;

namespace MovieApi.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=movies.db");
        }

    }
}
