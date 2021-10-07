using EPiServer.Find.UnifiedSearch;
using NackademinDemo.Models.Pages;

namespace NackademinDemo.Models.ViewModels
{
    public class ResultViewModel : PageViewModel<FindPage>
    {
        public UnifiedSearchResults Result { get; set; }

        public ResultViewModel(FindPage currentPage) : base(currentPage)
        {
        }
    }
}