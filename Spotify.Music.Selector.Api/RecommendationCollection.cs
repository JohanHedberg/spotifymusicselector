using System;
using System.Collections.Generic;
using System.Text;

namespace Spotify.Music.Selector.Api
{
    public class RecommendationCollection
    {
        public IEnumerable<Track> Tracks { get; set; }
    }
}