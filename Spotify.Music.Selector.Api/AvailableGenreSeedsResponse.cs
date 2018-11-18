using Newtonsoft.Json;
using System.Collections.Generic;

namespace Spotify.Music.Selector.Api
{
    /// <summary>
    /// Response returned by Spotify when requesting for available genres.
    /// </summary>
    public class AvailableGenreSeedsResponse
    {
        /// <summary>
        /// A collection of genre names.
        /// </summary>
        [JsonProperty(PropertyName = "genres")]
        public IEnumerable<string> Genres { get; set; }
    }
}