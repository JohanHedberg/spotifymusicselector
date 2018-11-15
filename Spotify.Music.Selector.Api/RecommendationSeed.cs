using Newtonsoft.Json;

namespace Spotify.Music.Selector.Api
{
    public class RecommendationSeed
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "type")]
        public RecommendationSeedType Type { get; set; }
    }
}