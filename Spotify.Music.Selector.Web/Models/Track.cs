using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spotify.Music.Selector.Web.Models
{
    public class Track
    {
        public IEnumerable<Artist> Artists { get; set; }

        public Album Album { get; set; }

        public string Name { get; set; }

        public string Id { get; set; }

        public IEnumerable<Artist> AvailableMarkets { get; set; }
    }
}