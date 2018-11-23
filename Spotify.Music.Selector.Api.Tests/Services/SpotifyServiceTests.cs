using Microsoft.Extensions.Configuration;
using Moq;
using Spotify.Music.Selector.Api.Services;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Spotify.Music.Selector.Api.Tests.Services
{
    public class SpotifyServiceTests
    {
        [Fact]
        public void SetAuthorizationCode_WhenNotNull_ShouldSetRequiresAuthenticationToFalse()
        {
            var httpClient = new HttpClient();
            var code = "secret";
            _subject.SetAuthorizationCode(code);

            Assert.False(_subject.RequiresAuthentication);
        }

        [Fact]
        public void SetAuthorizationCode_WhenNull_ShouldSetRequiresAuthenticationToTrue()
        {
            var httpClient = new HttpClient();
            string code = null;
            _subject.SetAuthorizationCode(code);

            Assert.True(_subject.RequiresAuthentication);
        }

        private readonly SpotifyService _subject;
        private readonly Mock<IConfiguration> _configurationMock;
        private readonly Mock<IHttpClientFactory> _httpClientFactoryMock;
        private readonly Mock<IConfigurationSection> _configurationSectionMock;

        public SpotifyServiceTests()
        {
            _configurationMock = new Mock<IConfiguration>();
            _httpClientFactoryMock = new Mock<IHttpClientFactory>();

            _configurationSectionMock = new Mock<IConfigurationSection>();
            _configurationMock.Setup(x => x.GetSection(It.IsAny<string>())).Returns(_configurationSectionMock.Object);

            _subject = new SpotifyService(_configurationMock.Object, _httpClientFactoryMock.Object);
        }

        class HttpClientForTest : HttpClient
        {
            public override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                return Task.Run(() => new HttpResponseMessage()
                {
                    Content = new HttpMessageContent(request),
                    StatusCode = HttpStatusCode.OK,
                    RequestMessage = request
                });
            }
        }
    }
}