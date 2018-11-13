using Moq;
using Spotify.Music.Selector.Api.Client;
using Spotify.Music.Selector.Web.Controllers;
using Xunit;

namespace Spotify.Music.Selector.Web.Tests.Controllers
{
    public class HomeControllerTests
    {
        [Fact]
        public void Index()
        {
            var result = _subject.Index();
        }

        [Fact]
        public void Callback()
        {
            var code = "ABC";
            var state = "state";
            var result = _subject.Callback(code, state);
        }

        private readonly Mock<ISpotifyClient> _spotifyClientMock;
        private readonly HomeController _subject;

        public HomeControllerTests()
        {
            _spotifyClientMock = new Mock<ISpotifyClient>();
            _subject = new HomeController(_spotifyClientMock.Object);
        }
    }
}