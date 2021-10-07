using EPiServer;
using EPiServer.ServiceLocation;
using NackademinDemo.Models.Pages;
using NackademinDemo.Models.ViewModels;
using System.Web.Mvc;

namespace NackademinDemo.Controllers
{
    public class ContentPageController : PageControllerBase<ContentPage>
    {
        public ActionResult Index(ContentPage currentPage)
        {
            var model = new ContentPageViewModel(currentPage)
            {                
            };

            return View(model);
        }
    }
}