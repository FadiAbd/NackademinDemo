using NackademinDemo.Models;
using System.Threading.Tasks;

namespace NackademinDemo.Abstractions
{
    public interface IMovieService
    {
        Task<MovieSearch> Search(string s);

        Task<Movie> GetMovie(string id);
    }
}