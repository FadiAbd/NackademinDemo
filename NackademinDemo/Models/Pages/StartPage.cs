using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using NackademinDemo.Abstractions;
using NackademinDemo.Models.Blocks;
using System.ComponentModel.DataAnnotations;

namespace NackademinDemo.Models.Pages
{
    [ContentType(
        GUID = "9B7223E7-B7FA-42CE-8D36-618B0E8AEECA",
        DisplayName = "Page: A start page"        
    )]
    //[ContentIcon(ContentIcon.IcoMoon.home2)]
    [ImageUrl("/static/img/startpage.png")]
    [AvailableContentTypes(
        Include = new[] { typeof(FoodPage), typeof(NewsContainer), typeof(MovieSearchPage), typeof(FindPage), typeof(ContentPage) }
    )]
    public class StartPage : SitePageData, IMyCustomProperties, INoIndex
    {
        [Display(
           GroupName = SystemTabNames.Content,
           Order = 10
        )]
        [CultureSpecific]
        public virtual string Header { get; set; }

        [Display(
           GroupName = SystemTabNames.Content,
           Order = 20
        )]
        [UIHint(UIHint.Textarea)]
        [CultureSpecific]
        public virtual string Preamble { get; set; }

        [Display(
          GroupName = SystemTabNames.Content,
          Order = 25
       )]
        [CultureSpecific]
        public virtual XhtmlString Text { get; set; }

        [Display(
           GroupName = SystemTabNames.Content,
           Order = 30
        )]
        [CultureSpecific]
        public virtual ContentArea ContentArea { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 40
        )]
        [UIHint("BackgroundColor")]
        public virtual string BackgroundColor { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 50
        )]
        public virtual NewsBlock News { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 60
        )]
        public virtual bool IsYouTube { get; set; }
    }
}