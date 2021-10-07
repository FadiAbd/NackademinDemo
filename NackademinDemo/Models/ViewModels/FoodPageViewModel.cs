using NackademinDemo.Models.Pages;

namespace NackademinDemo.Models.ViewModels
{
    public class FoodPageViewModel : PageViewModel<FoodPage>
    {
        public FoodPageViewModel(FoodPage currentPage) : base(currentPage)
        {
        }
    }
}