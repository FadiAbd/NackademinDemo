using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace NackademinDemo.Models.Blocks
{
    [ContentType(
        DisplayName = "Block: News",
        GUID = "f2e9fce2-fb5e-47c2-af76-22c0f53c1d25",
        Description = ""
    )]
    public class NewsBlock : BlockData
    {
        [CultureSpecific]
        [Display(
            Name = "Nyheter",
            Description = "Peka ut var nyheterna finns",
            GroupName = SystemTabNames.Content,
            Order = 10
        )]
        public virtual PageReference NewsContainer { get; set; }
    }
}