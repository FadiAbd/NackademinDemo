using EPiServer.Shell.Security;
using EPiServer.Web.Mvc;
using NackademinDemo.Business;
using NackademinDemo.Models.Pages;
using NackademinDemo.Models.ViewModels;
using System.Web.Mvc;

namespace NackademinDemo.Controllers
{
    public abstract class PageControllerBase<T> : PageController<T>, IModifyLayout
        where T : SitePageData
    {

        protected EPiServer.ServiceLocation.Injected<UISignInManager> UISignInManager;

        public ActionResult Logout()
        {
            UISignInManager.Service.SignOut();

            return RedirectToAction("Index");
        }

        public virtual void ModifyLayout(LayoutModel layoutModel)
        {
            var page = PageContext.Page as SitePageData;            
        }
    }
}