using Newtonsoft.Json;
using System.Collections.Generic;

namespace Spotify.Music.Selector.Api
{
    /// <summary>
    /// Represents a music album.
    /// </summary>
    public class Album
    {
        /// <summary>
        /// The name of the album.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The Spotify id of the album.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// A collection of artists who appears on the album.
        /// </summary>
        [JsonProperty(PropertyName = "artists")]
        public IEnumerable<Artist> Artists { get; set; }

        /// <summary>
        /// A collection of genres associated to the album.
        /// </summary>
        [JsonProperty(PropertyName = "genres")]
        public IEnumerable<string> Genres { get; set; }

        /// <summary>
        /// A collection of cover images.
        /// </summary>
        [JsonProperty(PropertyName = "images")]
        public IEnumerable<Image> Images { get; set; }
    }
}