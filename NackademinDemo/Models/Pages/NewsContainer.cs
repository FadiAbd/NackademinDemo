using EPiServer.DataAnnotations;

namespace NackademinDemo.Models.Pages
{
    [ContentType(
        GUID = "37F941D7-1A5F-40AB-8A18-F36A89AB03BD",        
        DisplayName = "Container: News",
        Description = "Här lägger vi in alla nyheter"        
    )]
    [AvailableContentTypes(
        Include = new[] { typeof(NewsPage) }
    )]
    public class NewsContainer : SitePageData
    {

    }
}