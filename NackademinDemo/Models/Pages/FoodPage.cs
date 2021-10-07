using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace NackademinDemo.Models.Pages
{
    [ContentType(
        GUID = "2BECC73D-3276-4CD2-88B2-22E6C76F787B",
        DisplayName = "Page: Holding data about food"
    )]
    public class FoodPage : SitePageData
    {
        [Display(
           GroupName = SystemTabNames.Content,
           Order = 20
        )]
        [UIHint(UIHint.Textarea)]
        [CultureSpecific]
        public virtual string Preamble { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 30
        )]
        [CultureSpecific]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }
    }
}