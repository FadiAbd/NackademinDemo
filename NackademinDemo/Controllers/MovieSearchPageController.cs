using NackademinDemo.Abstractions;
using NackademinDemo.Models.Pages;
using NackademinDemo.Models.ViewModels;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace NackademinDemo.Controllers
{
    public class MovieSearchPageController : PageControllerBase<MovieSearchPage>
    {
        private IMovieService _movieService;

        public MovieSearchPageController(IMovieService movieService)
        { 
            _movieService = movieService;
        }

        public async Task<ActionResult> Index(MovieSearchPage currentPage, string query)
        {
            if (query == null)
            {
                return View(new MovieSearchViewModel(currentPage));
            }
            else
            {
                var movies = await _movieService.Search(query);

                var model = new MovieSearchViewModel(currentPage)
                {
                    Search = movies
                };

                return View(model);
            }
        }

        [HttpGet]
        public async Task<ActionResult> GetMovie(MovieSearchPage currentPage, string id)
        {
            var movie = await _movieService.GetMovie(id);

            var model = new MovieSearchViewModel(currentPage)
            {
                Movie = movie
            };

            return View(model);
        }
    }
}