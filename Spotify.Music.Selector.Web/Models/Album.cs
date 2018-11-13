using System.Collections.Generic;

namespace Spotify.Music.Selector.Web.Models
{
    public class Album
    {
        public string Name { get; set; }

        public string Id { get; set; }

        public IEnumerable<Artist> Artists { get; set; }
    }
}