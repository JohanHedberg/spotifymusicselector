using Newtonsoft.Json;
using System.Collections.Generic;

namespace Spotify.Music.Selector.Api
{
    /// <summary>
    /// Response returned as result when fetching music recommendations.
    /// </summary>
    public class RecommendationsResponse
    {
        /// <summary>
        /// A collection of <see cref="RecommendationSeed"/>s.
        /// </summary>
        [JsonProperty(PropertyName = "seeds")]
        public IEnumerable<RecommendationSeed> Seeds { get; set; }

        /// <summary>
        /// A collection of recommended music <see cref="Track"/>s.
        /// </summary>
        [JsonProperty(PropertyName = "tracks")]
        public IEnumerable<Track> Tracks { get; set; }
    }
}