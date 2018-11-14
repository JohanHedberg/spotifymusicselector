using Newtonsoft.Json;
using System.Collections.Generic;

namespace Spotify.Music.Selector.Api
{
    /// <summary>
    /// Represents a music Track.
    /// </summary>
    /// <see cref="https://developer.spotify.com/documentation/web-api/reference/object-model/#track-object-full"/>
    public class Track
    {
        [JsonProperty(PropertyName = "artists")]
        public IEnumerable<Artist> Artists { get; set; }

        [JsonProperty(PropertyName = "album")]
        public Album Album { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "available_markets")]
        public IEnumerable<string> AvailableMarkets { get; set; }
    }
}