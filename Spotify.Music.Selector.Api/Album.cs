using Newtonsoft.Json;
using System.Collections.Generic;

namespace Spotify.Music.Selector.Api
{
    public class Album
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "artists")]
        public IEnumerable<Artist> Artists { get; set; }
    }
}