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


        [JsonProperty(PropertyName = "genres")]
        public IEnumerable<string> Genres { get; set; }

        [JsonProperty(PropertyName = "images")]
        public IEnumerable<Image> Images { get; set; }
    }
}