using Moq;
using Spotify.Music.Selector.Api.Services;
using Spotify.Music.Selector.Web.Controllers;
using Xunit;

namespace Spotify.Music.Selector.Web.Tests.Controllers
{
    public class AuthorizationControllerTests
    {
        [Fact]
        public void Callback()
        {
            var code = "ABC";
            var state = "state";
            var result = _subject.Callback(code, state);
        }

        private readonly Mock<ISpotifyService> _spotifyClientMock;
        private readonly AuthorizationController _subject;

        public AuthorizationControllerTests()
        {
            _spotifyClientMock = new Mock<ISpotifyService>();
            _subject = new AuthorizationController(_spotifyClientMock.Object);
        }
    }
}