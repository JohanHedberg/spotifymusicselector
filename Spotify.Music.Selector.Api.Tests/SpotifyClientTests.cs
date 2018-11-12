using System.Net.Http;
using Xunit;

namespace Spotify.Music.Selector.Api.Tests
{
    public class SpotifyClientTests
    {
        [Fact]
        public void GetAlbum()
        {
            var result = _subject.GetAlbum();
        }

        [Fact]
        public void GetAGetArtistlbum()
        {
            var result = _subject.GetArtist();
        }

        [Fact]
        public void GetRecommendations()
        {
            var result = _subject.GetRecommendations();
        }

        [Fact]
        public async void GetAccessToken()
        {
            var accessCode = "";

            var result = await _subject.GetAccessToken(accessCode);

            Assert.NotNull(result);
        }

        private readonly SpotifyClient _subject;

        public SpotifyClientTests()
        {
            var client = new HttpClient();

            _subject = new SpotifyClient(
                client,
                callbackUri: "https://localhost:44346/authentication/callback", 
                clientId: "",
                clientSecret: ""
        }
    }
}