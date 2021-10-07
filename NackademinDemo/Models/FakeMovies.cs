using NackademinDemo.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NackademinDemo.Models
{
    public class FakeMovies
    {
        public Task<MovieSearch> Search(string s)
        {
            var movies = new List<Movie>
            {
                new Movie()
                {
                    Title = "Die Hard",
                    Year = "1988"
                }
            };

            var result = GetMovies(movies);

            return result;
        }

        private async Task<MovieSearch> GetMovies(List<Movie> movies)
        {
            var movieSearch = new MovieSearch();
            movieSearch.Search = movies;

            return movieSearch;
        }
    }
}