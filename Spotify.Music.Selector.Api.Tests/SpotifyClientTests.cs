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
            var accessCode = "AQAT9jVPiiKM7aNQdoZ3GypKX3p-Gw2U_fZcnyTqVLu6tyAXrilVoFw5ZSmz_TL_XenaN_bu2I8q569ywIiMTjjTi2SwYLEsVU8A2gj7mz1aZWUIGOir8_x5vgPrw9DSeXsUOhp9rck7FzXtgR90ZzkDXsmur5hRlWMbnJUBQcF7Eodgi7yNW_kVlizh8oBWFRUSZvLFm2xKaALoGHx2lAy24wQUYiE";

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
                clientId: "cb4255ea66f9464dbaacfbbf3fd7ecd1", 
                clientSecret: "fadd11d8043f4e1d82c33f68dc224428");
        }
    }
}