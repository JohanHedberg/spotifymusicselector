using System.Collections.Generic;

namespace Spotify.Music.Selector.Web.Models
{
    public class Track
    {
        public Track(Api.Track track)
        {
            Name = track.Name;
            Album = new Album(track.Album);
            Id = track.Id;
            AvailableMarkets = track.AvailableMarkets;
        }

        public IEnumerable<Artist> Artists { get; set; }

        public Album Album { get; set; }

        public string Name { get; set; }

        public string Id { get; set; }

        public IEnumerable<string> AvailableMarkets { get; set; }
    }
}