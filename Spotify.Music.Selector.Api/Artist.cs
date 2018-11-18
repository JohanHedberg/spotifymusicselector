using Newtonsoft.Json;

namespace Spotify.Music.Selector.Api
{
    /// <summary>
    /// Representation of  an artist.
    /// </summary>
    public class Artist
    {
        /// <summary>
        /// The artist's name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The Spotify id of the artist.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
    }
}