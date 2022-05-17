using MovieApplication.Models;

namespace MovieApplication.Repositories
{
    public interface IMovieRepository
    {
        Task<IEnumerable<Models.Movie>> GetAll();
        Task<IEnumerable<Models.Movie>> Get(int id);
        Task<IEnumerable<Models.Movie>> Create(Models.Movie movie);
        Task<IEnumerable<Models.Movie>> Update(Models.Movie movie);
        Task Delete(int id);
        Task<IEnumerable<Movie>> Get();
    }
}
