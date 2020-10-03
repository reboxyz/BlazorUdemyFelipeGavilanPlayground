using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorMovies.Shared.Entities;

namespace BlazorMovies.Client.Repository
{
    public interface IGenreRepository
    {
        Task<List<Genre>> GetGenres();
        Task<Genre> GetGenre(int id);
        Task CreateGenre(Genre genre);
        Task UpdateGenre(Genre genre);
        Task DeleteGenre(int id);
    }
}