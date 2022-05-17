using Microsoft.AspNetCore.Mvc;
using MovieApplication.Models;
using MovieApplication.Repositories;

namespace MovieApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieRepository _movieRepository;

        public MoviesController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
        [HttpGet]
        public async Task<IEnumerable<Movie>> GetMovies()
        {
            return await _movieRepository.Get();
        }


        [HttpGet("{id}")]
        public Task<ActionResult<Movie>> GetMovies(int id, ActionResult<Movie> enumerable)
        {
            return Task.FromResult(enumerable);
        }

        [HttpPost]
        public async Task<ActionResult<Movie>> GetMovies(Movie movie)
        {
            var newMovie = await _movieRepository.Create(movie);
            return CreatedAtAction(nameof(GetMovies), newMovie);
        }
    }
}
