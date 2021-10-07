using NackademinDemo.Models.Pages;

namespace NackademinDemo.Models.ViewModels.Interfaces
{
    public interface IPageViewModel<out T> where T : SitePageData
    {
        T CurrentPage { get; }

        LayoutModel Layout { get; set; }
    }
}