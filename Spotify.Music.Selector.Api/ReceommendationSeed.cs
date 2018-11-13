using Newtonsoft.Json;

namespace Spotify.Music.Selector.Api
{
    public class ReceommendationSeed
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
    }
}