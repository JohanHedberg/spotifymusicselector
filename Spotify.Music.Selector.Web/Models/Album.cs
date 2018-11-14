using System.Collections.Generic;
using System.Linq;

namespace Spotify.Music.Selector.Web.Models
{
    public class Album
    {
        public Album(Api.Album album)
        {
            Name = album.Name;
            Id = album.Id;
            Artists = album.Artists.Select(artist => new Artist(artist));
            Genres = album.Genres;
            Images = album.Images.Select(image => new Image(image));
        }

        public string Name { get; set; }

        public string Id { get; set; }

        public IEnumerable<Artist> Artists { get; set; }

        public IEnumerable<string> Genres { get; set; }

        public IEnumerable<Image> Images { get; set; }
    }
}