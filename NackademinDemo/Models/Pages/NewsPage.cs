using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using NackademinDemo.Business.UIDescriptors;
using System.ComponentModel.DataAnnotations;

namespace NackademinDemo.Models.Pages
{
    [ContentType(
        DisplayName = "NewsPage",
        GUID = "c4723c77-503d-4345-9395-27a1fc3c7bfa",
        Description = "Page: News"
    )]
    public class NewsPage : PageData, IUseNewsTreeIcon
    {
        [CultureSpecific]
        [Display(
            Name = "Rubrik",
            Description = "Här är nyhetens rubrik",
            GroupName = SystemTabNames.Content,
            Order = 10
        )]
        public virtual string Header { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Text",
            Description = "Här är nyhetens text",
            GroupName = SystemTabNames.Content,
            Order = 20
        )]
        public virtual XhtmlString Text { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Bild",
            Description = "Här är nyhetens bild",
            GroupName = SystemTabNames.Content,
            Order = 30
        )]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }
    }
}