using Newtonsoft.Json;

namespace Spotify.Music.Selector.Api
{
    /// <summary>
    /// Criteria used when fecthing music recommendations.
    /// </summary>
    public class RecommendationSeed
    {
        /// <summary>
        /// The identifier of the seed. Depending on the seed type this could
        /// be the if of an artist or the name of a genre.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The seed's type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public RecommendationSeedType Type { get; set; }
    }
}