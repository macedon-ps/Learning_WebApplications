using CinemaApp.ContextBd;
using CinemaApp.Interfaces;
using CinemaApp.Models;

namespace CinemaApp.Repositories
{
    public class MoviesRepository : IMovies
    {
        private readonly CinemaDbContext _context;

        public MoviesRepository(CinemaDbContext context)
        {
            _context = context;
        }

        public List<Movie> GetAllMovies()
        {
            var movies = _context.Movies.ToList();

            return movies;
        }

        public Movie CreateMovie(Movie movie)
        {
            throw new NotImplementedException();
        }

        public void DeleteMovie(int id)
        {
            throw new NotImplementedException();
        }

        public Movie GetMovieById(int id)
        {
            throw new NotImplementedException();
        }

        public Movie GetMovieBySearchQuery(string searchQuery)
        {
            throw new NotImplementedException();
        }

        public Movie UpdateMovie(int id)
        {
            throw new NotImplementedException();
        }
    }
}
