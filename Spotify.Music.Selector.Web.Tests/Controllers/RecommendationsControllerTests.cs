using Moq;
using Spotify.Music.Selector.Api.Client;
using Spotify.Music.Selector.Web.Controllers;
using Xunit;

namespace Spotify.Music.Selector.Web.Tests.Controllers
{
    public class RecommendationControllerTests
    {
        [Fact]
        public void Get()
        {
            var result = _subject.Get();
        }

        private readonly Mock<ISpotifyClient> _spotifyClientMock;
        private readonly RecommendationsController _subject;

        public RecommendationControllerTests()
        {
            _spotifyClientMock = new Mock<ISpotifyClient>();
            _subject = new RecommendationsController(_spotifyClientMock.Object);
        }
    }
}