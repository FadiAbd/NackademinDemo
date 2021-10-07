using EPiServer.Data.Dynamic;
using NackademinDemo.Abstractions;
using NackademinDemo.Models;
using System.Collections.Generic;
using System.Linq;

namespace NackademinDemo.Services
{
    public class DdsService : IDdsService
    {
        public List<Movie> CreateMovies()
        {
            var movies = new List<Movie>();

            var movie1 = new Movie()
            {
                Title = "Inception",
                ImdbID = "535345",
                Poster = "xxxx.jpg",
                Type = "movie",
                Year = "2013"
            };

            var movie2 = new Movie()
            {
                Title = "Emma",
                ImdbID = "86875",
                Poster = "yyyy.jpg",
                Type = "movie",
                Year = "2020"
            };

            var movie3 = new Movie()
            {
                Title = "Bad Boys",
                ImdbID = "245432",
                Poster = "zzzz.jpg",
                Type = "movie",
                Year = "2002"
            };

            movies.Add(movie1);
            movies.Add(movie2);
            movies.Add(movie3);

            return movies;
        }

        public void CreateStore(List<Movie> movies)
        {
            foreach (var movie in movies)
            {
                var store = DynamicDataStoreFactory.Instance.CreateStore(typeof(Movie));

                store.Save(movie);
            }
        }

        public List<Movie> GetMovies()
        {
            var store = DynamicDataStoreFactory.Instance.CreateStore(typeof(Movie));
            var movies = store.Items<Movie>().ToList();

            return movies;
        }

        public int DeleteMovies()
        {
            var store = DynamicDataStoreFactory.Instance.CreateStore(typeof(Movie));
            DynamicDataStoreFactory.Instance.DeleteStore(typeof(Movie), true);

            return store.Items<Movie>().ToList().Count;
        }
    }
}