using NackademinDemo.Models;
using System.Collections.Generic;

namespace NackademinDemo.Abstractions
{
    public interface IDdsService
    {
        List<Movie> CreateMovies();

        void CreateStore(List<Movie> movies);

        List<Movie> GetMovies();

        int DeleteMovies();
    }
}