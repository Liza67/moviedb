using MovieApplication.Models;

namespace MovieApplication.Repositories
{
    public class MovieRepository : MovieRepositoryBase, IMovieRepository
    {
        private MovieStoreDBContext _context;


        public MovieRepository(MovieStoreDBContext context)
        {
            _context = context;
        }

        public Movie movieToDelete { get; private set; }

        public async Task Delete(int id)
        {
            var bookToDelete = await _context.Movies.FindAsync(id);
            _context.Movies.Remove(movieToDelete);
            await _context.SaveChangesAsync();
        }

        public Task<IEnumerable<Movie>> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Movie>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Movie>> Update(Movie movie)
        {
            throw new NotImplementedException();
        }
    }
}
