using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DependancyInjectionProject.Services;

namespace DependancyInjectionProject.Web.Controllers
{
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly ILogger<MoviesController> _logger;
        private readonly IMovieService _movieService;

        public MoviesController(ILogger<MoviesController> logger, IMovieService movieService) {
            _logger = logger;
            _movieService = movieService;
        }

        [HttpGet("/api/Movies")]
        public ActionResult GetAllMovies() {
            var movies = _movieService.GetAllMovies();
            return Ok(movies);
        }

        [HttpGet("/api/Movies/{id}")]
        public ActionResult GetMovies(int id) {
            var movies = _movieService.GetMovie(id);
            return Ok(movies);
        }

    }
}
