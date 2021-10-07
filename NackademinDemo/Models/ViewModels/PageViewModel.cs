using NackademinDemo.Models.Pages;
using NackademinDemo.Models.ViewModels.Interfaces;

namespace NackademinDemo.Models.ViewModels
{
    public class PageViewModel<T> : IPageViewModel<T> where T : SitePageData
    {       
        public T CurrentPage { get; private set; }

        public LayoutModel Layout { get; set; }

        public PageViewModel(T currentPage)
        {
            CurrentPage = currentPage;
        }
    }
}