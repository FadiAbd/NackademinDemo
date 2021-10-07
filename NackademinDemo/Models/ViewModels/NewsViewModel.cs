using NackademinDemo.Models.Pages;
using System.Collections.Generic;

namespace NackademinDemo.Models.ViewModels
{
    public class NewsViewModel
    {
        public IEnumerable<NewsPage> News { get; set; }
    }
}