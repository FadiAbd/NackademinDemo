using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;
using NackademinDemo.Models.Blocks;
using NackademinDemo.Models.Pages;
using NackademinDemo.Models.ViewModels;
using System.Web.Mvc;

namespace NackademinDemo.Controllers.Blocks
{
    public class NewsBlockController : BlockController<NewsBlock>
    {
        private readonly IContentLoader _contentLoader = ServiceLocator.Current.GetInstance<IContentLoader>();
        
        public override ActionResult Index(NewsBlock currentBlock)
        {
            NewsContainer newsContainer = null;

            if (!ContentReference.IsNullOrEmpty(currentBlock.NewsContainer))
            {
                newsContainer = _contentLoader.Get<NewsContainer>(currentBlock.NewsContainer);
            }

            var model = new NewsViewModel()
            {
                News = _contentLoader.GetChildren<NewsPage>(newsContainer.ContentLink)
            };

            return PartialView(model);
        }
    }
}