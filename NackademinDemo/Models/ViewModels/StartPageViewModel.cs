using NackademinDemo.Models.Pages;
using System.Collections.Generic;
using StartPage = NackademinDemo.Models.Pages.StartPage;

namespace NackademinDemo.Models.ViewModels
{
    public class StartPageViewModel : PageViewModel<StartPage>
    {
        public IEnumerable<FoodPage> Food { get; set; }

        public StartPageViewModel(StartPage currentPage) : base(currentPage)
        {
        }
    }
}