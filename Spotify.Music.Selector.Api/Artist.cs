using Newtonsoft.Json;

namespace Spotify.Music.Selector.Api
{
    public class Artist
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
    }
}