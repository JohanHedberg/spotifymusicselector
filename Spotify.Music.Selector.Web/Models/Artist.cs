namespace Spotify.Music.Selector.Web.Models
{
    public class Artist
    {
        public Artist(Api.Artist artist)
        {
            Name = artist.Name;
            Id = artist.Id;
        }

        public string Name { get; set; }

        public string Id { get; set; }
    }
}