using Spotify.Music.Selector.Api.Extensions;
using Xunit;

namespace Spotify.Music.Selector.Api.Tests.Extensions
{
    public class RecommendationSeedExtensionsTests
    {
        [Fact]
        public void GetQuery_WhenEmptyCollection_ShouldReturnEmptyString()
        {
            var subject = new RecommendationSeed[0];
            var result = subject.GetSeedQuery();

            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void GetQuery_WhenContainingSingleGenre_ShouldReturnSeedGenres()
        {
            var subject = new[] { new RecommendationSeed { Id = "my_genre", Type = RecommendationSeedType.Genre } };
            var result = subject.GetSeedQuery();
            var expected = "&seed_genres=my_genre";

            Assert.Equal(expected, result);
        }

        [Fact]
        public void GetQuery_WhenMultipleGenre_ShouldContainCommaSeparatedString()
        {
            var subject = new[] {
                new RecommendationSeed { Id = "first_genre", Type = RecommendationSeedType.Genre },
                new RecommendationSeed { Id = "second_genre", Type = RecommendationSeedType.Genre }
            };
            var result = subject.GetSeedQuery();
            var expected = "&seed_genres=first_genre,second_genre";

            Assert.Equal(expected, result);
        }

        [Fact]
        public void GetQuery_WhenMultipleMixedTypes_ShouldContainAllValuesGroupedByType()
        {
            var subject = new[] {
                new RecommendationSeed { Id = "A", Type = RecommendationSeedType.Genre },
                new RecommendationSeed { Id = "B", Type = RecommendationSeedType.Album },
                new RecommendationSeed { Id = "C", Type = RecommendationSeedType.Genre },
                new RecommendationSeed { Id = "D", Type = RecommendationSeedType.Artist },
                new RecommendationSeed { Id = "E", Type = RecommendationSeedType.Genre }
            };
            var result = subject.GetSeedQuery();
            var expected = "&seed_genres=A,C,E&seed_artists=D&seed_albums=B";
            
            Assert.Equal(expected, result);
        }
    }
}