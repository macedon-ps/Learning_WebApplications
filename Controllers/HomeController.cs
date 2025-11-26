using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CinemaApp.Models;
using CinemaApp.Interfaces;

namespace CinemaApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMovies _movie;

        public HomeController(ILogger<HomeController> logger, IMovies movie)
        {
            _logger = logger;
            _movie = movie;
        }

        public IActionResult Index()
        {
            var movies = _movie.GetAllMovies();

            return View(movies);
        }

        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
