using Newtonsoft.Json;
using System.Collections.Generic;

namespace NackademinDemo.Models
{
    public class MovieSearch
    {
        [JsonProperty("Search")]
        public IEnumerable<Movie> Search { get; set; }

        [JsonProperty("totalResults")]
        public string TotalResults { get; set; }

        [JsonProperty("Response")]
        public string Response { get; set; }
    }
}