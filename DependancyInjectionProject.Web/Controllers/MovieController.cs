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
        public IActionResult GetAll() {
            return Ok(_movieService.GetAll());
        }

        [HttpGet("/api/Movies/{name}")]
        public IActionResult Get(string name) {
            return Ok(_movieService.Get(name));
        }

        [HttpGet("/api/Movies/{id:int}")]
        public IActionResult Get(int id) {
            return Ok(_movieService.Get(id));
        }
    }
}
