
using Microsoft.EntityFrameworkCore;
using CinemaApp.Models;

namespace CinemaApp.ContextBd
{
    public class CinemaContextBd : DbContext
    {
        public CinemaContextBd(DbContextOptions<CinemaContextBd> options) : base(options)
        {
        }
        public DbSet<Movie> Movies { get; set; }
    }
}
