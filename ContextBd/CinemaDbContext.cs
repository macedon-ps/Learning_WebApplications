
using Microsoft.EntityFrameworkCore;
using CinemaApp.Models;

namespace CinemaApp.ContextBd
{
    public class CinemaDbContext : DbContext
    {
        public CinemaDbContext(DbContextOptions<CinemaDbContext> options) : base(options)
        {
        }
        public DbSet<Movie> Movies { get; set; }
    }
}
