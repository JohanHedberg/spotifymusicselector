﻿using Newtonsoft.Json;

namespace Spotify.Music.Selector.Api
{
    public class Image
    {
        [JsonProperty(PropertyName = "height")]
        public int Height { get; set; }

        [JsonProperty(PropertyName = "width")]
        public int Width { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
    }
}