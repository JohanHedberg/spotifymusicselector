namespace Spotify.Music.Selector.Web.Models
{
    public class Image
    {
        public Image(Api.Image image)
        {
            Height = image.Height;
            Width = image.Width;
            Url = image.Url;
        }

        public int Height { get; set; }

        public int Width { get; set; }

        public string Url { get; set; }
    }
}