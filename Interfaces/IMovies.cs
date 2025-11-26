using CinemaApp.Models;

namespace CinemaApp.Interfaces
{
    public interface IMovies
    {
        List<Movie> GetAllMovies();

        Movie GetMovieById(int id);

        Movie GetMovieBySearchQuery(string searchQuery);

        Movie CreateMovie(Movie movie);

        Movie UpdateMovie(int id);

        void DeleteMovie(int id);

    }
}
