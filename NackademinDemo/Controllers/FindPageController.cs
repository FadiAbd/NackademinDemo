using NackademinDemo.Models.Pages;
using NackademinDemo.Models.ViewModels;
using System.Web.Mvc;
using EPiServer.Find;
using EPiServer.Find.Framework;
using EPiServer.Find.UnifiedSearch;

namespace NackademinDemo.Controllers
{
    public class FindPageController : PageControllerBase<FindPage>
    {
        public ActionResult Index(FindPage currentPage, string query)
        {
            var model = new ResultViewModel(currentPage);

            var hitSpec = new HitSpecification
            {
                ExcerptLength = 255
            };

            if (string.IsNullOrWhiteSpace(query))
            {
                return View(model);
            }
            else
            {
                var result = SearchClient.Instance.UnifiedSearchFor(query, Language.English).GetResult(hitSpec);
                //todo filtrera er sökning

                model.Result = result;
            }

            return View(model);
        }
    }
}