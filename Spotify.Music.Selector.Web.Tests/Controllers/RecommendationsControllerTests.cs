using Moq;
using Spotify.Music.Selector.Api.Services;
using Spotify.Music.Selector.Web.Controllers;
using Xunit;

namespace Spotify.Music.Selector.Web.Tests.Controllers
{
    public class RecommendationControllerTests
    {
        [Fact]
        public void Get()
        {
            var genre = "rock";
            var artistId = "13654";
            var result = _subject.Get(genre, artistId);
        }

        private readonly Mock<ISpotifyService> _spotifyClientMock;
        private readonly RecommendationsController _subject;

        public RecommendationControllerTests()
        {
            _spotifyClientMock = new Mock<ISpotifyService>();
            _subject = new RecommendationsController(_spotifyClientMock.Object);
        }
    }
}