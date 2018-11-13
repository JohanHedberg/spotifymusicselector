using Microsoft.Extensions.Configuration;
using Moq;
using Spotify.Music.Selector.Api.Client;
using System.Net.Http;
using Xunit;

namespace Spotify.Music.Selector.Api.Tests.Client
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
            var httpClient = new HttpClient();

            var result = await _subject.GetAccessToken(httpClient);

            Assert.NotNull(result);
        }

        private readonly SpotifyClient _subject;
        private readonly Mock<IConfiguration> _configurationMock;
        private readonly Mock<IHttpClientFactory> _httpClientFactoryMock;

        public SpotifyClientTests()
        {
            _configurationMock = new Mock<IConfiguration>();
            _httpClientFactoryMock = new Mock<IHttpClientFactory>();

            _subject = new SpotifyClient(_configurationMock.Object, _httpClientFactoryMock.Object);
        }
    }
}