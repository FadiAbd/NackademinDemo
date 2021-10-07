using NackademinDemo.Models.Pages;

namespace NackademinDemo.Models.ViewModels
{
    public class MovieSearchViewModel : PageViewModel<MovieSearchPage>
    {
        public MovieSearch Search { get; set; }

        public Movie Movie { get; set; }

        public MovieSearchViewModel(MovieSearchPage currentPage) : base(currentPage)
        {

        }
    }
}