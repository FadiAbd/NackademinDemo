using NackademinDemo.Abstractions;
using NackademinDemo.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace NackademinDemo.Services
{
    public class MovieService : IMovieService
    {
        public async Task<MovieSearch> Search(string s)
        {
            string url = $"http://www.omdbapi.com/?apikey={Constants.OmdbApiKey}&s={s}";

            MovieSearch searchResult = null;

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    searchResult = await response.Content.ReadAsAsync<MovieSearch>();
                }
            }

            return searchResult;
        }

        public async Task<Movie> GetMovie(string id)
        {
            string url = $"http://www.omdbapi.com/?apikey={Constants.OmdbApiKey}&i={id}";

            Movie searchResult = null;

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    searchResult = await response.Content.ReadAsAsync<Movie>();
                }
            }

            return searchResult;
        }

        public void AllMovies(MovieSearch movies)
        {
            var pages = Math.Ceiling(decimal.Parse(movies.TotalResults)/10);
        }
    }
}