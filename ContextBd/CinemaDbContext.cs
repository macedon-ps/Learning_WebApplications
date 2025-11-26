
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    Id = 1,
                    Title = "Аватар",
                    Genre = "Sci-Fi",
                    Country = "США",
                    ReleaseYear = 2009,
                    Price = 11.00m,
                    BoxOfficeReceipts = 2923706026
                },
                new Movie
                {
                    Id = 2,
                    Title = "Мстители: Конец игры",
                    Genre = "Superhero",
                    Country = "США",
                    ReleaseYear = 2019,
                    Price = 12.00m,
                    BoxOfficeReceipts = 2799439100
                },
                new Movie
                {
                    Id = 3,
                    Title = "Top Gun: Maverick",
                    Genre = "Action",
                    Country = "США",
                    ReleaseYear = 2022,
                    Price = 11.50m,
                    BoxOfficeReceipts = 1495696292
                },
                new Movie
                {
                    Id = 4,
                    Title = "Джокер",
                    Genre = "Thriller/Drama",
                    Country = "США",
                    ReleaseYear = 2019,
                    Price = 10.50m,
                    BoxOfficeReceipts = 1074458282
                },
                new Movie
                {
                    Id = 5,
                    Title = "Гарри Поттер и дары смерти: Часть 2",
                    Genre = "Fantasy",
                    Country = "Великобритания",
                    ReleaseYear = 2011,
                    Price = 10.20m,
                    BoxOfficeReceipts = 1342359942
                }
            );
        }
    }
}
