using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace NackademinDemo.Models.Pages
{
    [ContentType(
        GUID = "A2300906-2FDE-4244-9971-7EDCE77D5190",
        DisplayName = "Page: A content page"        
    )]
    //[ContentIcon(ContentIcon.IcoMoon.home2)]
    //[ImageUrl("/static/img/startpage.png")]
    //[AvailableContentTypes(
    //    Include = new[] { }
    //)]
    public class ContentPage : SitePageData
    {
        
    }
}