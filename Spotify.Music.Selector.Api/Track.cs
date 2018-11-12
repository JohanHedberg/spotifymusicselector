using System;
using System.Collections.Generic;
using System.Text;

namespace Spotify.Music.Selector.Api
{
    /// <summary>
    /// Represents a music Track.
    /// </summary>
    /// <see cref="https://developer.spotify.com/documentation/web-api/reference/object-model/#track-object-full"/>
    public class Track
    {
        public string Name { get; set; }
    }
}