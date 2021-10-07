using NackademinDemo.Models.Pages;
using NackademinDemo.Models.ViewModels;
using System.Web.Mvc;

namespace NackademinDemo.Controllers
{
    public class FoodPageController : PageControllerBase<FoodPage>
    {
        public ActionResult Index(FoodPage currentPage)
        {
            var model = new FoodPageViewModel(currentPage);

            return View(model);
        }
    }
}