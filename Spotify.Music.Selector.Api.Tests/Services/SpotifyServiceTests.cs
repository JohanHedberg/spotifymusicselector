using Microsoft.Extensions.Configuration;
using Moq;
using Spotify.Music.Selector.Api.Services;
using System.Net.Http;
using Xunit;

namespace Spotify.Music.Selector.Api.Tests.Services
{
    public class SpotifyServiceTests
    {
        [Fact(Skip = "Configuration must be mocked.")]
        public async void GetAccessToken()
        {
            var httpClient = new HttpClient();

            var result = await _subject.GetAccessToken(httpClient);

            Assert.NotNull(result);
        }

        [Fact(Skip = "Configuration must be mocked.")]
        public void SetAuthorizationCode()
        {
            var httpClient = new HttpClient();
            var code = "secret";
            _subject.SetAuthorizationCode(code);

            Assert.False(_subject.RequiresAuthentication);
        }

        private readonly SpotifyService _subject;
        private readonly Mock<IConfiguration> _configurationMock;
        private readonly Mock<IHttpClientFactory> _httpClientFactoryMock;

        public SpotifyServiceTests()
        {
            _configurationMock = new Mock<IConfiguration>();
            _httpClientFactoryMock = new Mock<IHttpClientFactory>();

            _subject = new SpotifyService(_configurationMock.Object, _httpClientFactoryMock.Object);
        }
    }
}