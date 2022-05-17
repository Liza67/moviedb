using MovieApplication.Models;

namespace MovieApplication.Repositories
{
    public class MovieRepositoryBase
    {
        private readonly object _context;

        public async Task<IEnumerable<Movie>> Create(Movie movie)
        {

            return (IEnumerable<Movie>)movie;
        }
    }
}