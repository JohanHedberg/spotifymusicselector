using Newtonsoft.Json;
using System.Collections.Generic;

namespace Spotify.Music.Selector.Api
{
    public class RecommendationsResponse
    {
        [JsonProperty(PropertyName = "seeds")]
        public IEnumerable<RecommendationSeed> Seeds { get; set; }

        [JsonProperty(PropertyName = "tracks")]
        public IEnumerable<Track> Tracks { get; set; }
    }
}