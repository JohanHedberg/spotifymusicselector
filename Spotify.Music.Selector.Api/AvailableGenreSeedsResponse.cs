using Newtonsoft.Json;
using System.Collections.Generic;

namespace Spotify.Music.Selector.Api
{
    public class AvailableGenreSeedsResponse
    {
        [JsonProperty(PropertyName = "genres")]
        public IEnumerable<string> Genres { get; set; }
    }
}