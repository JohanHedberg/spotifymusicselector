using Newtonsoft.Json;

namespace Spotify.Music.Selector.Api
{
    /// <summary>
    /// Image object, usually representing the cover
    /// image of a music album.
    /// </summary>
    public class Image
    {
        /// <summary>
        /// The size height of the image.
        /// </summary>
        [JsonProperty(PropertyName = "height")]
        public int Height { get; set; }

        /// <summary>
        /// The size width of the image.
        /// </summary>
        [JsonProperty(PropertyName = "width")]
        public int Width { get; set; }

        /// <summary>
        /// The url of the image.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
    }
}