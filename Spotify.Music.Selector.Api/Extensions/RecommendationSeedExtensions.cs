using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spotify.Music.Selector.Api.Extensions
{
    /// <summary>
    /// Extension methods used for collections of <see cref="RecommendationSeed"/>s.
    /// </summary>
    public static class RecommendationSeedExtensions
    {
        /// <summary>
        /// Gets the string used for stating the seeds when fetching music recommendations.
        /// </summary>
        /// <param name="seeds">A collection of <see cref="RecommendationSeed"/>s.</param>
        /// <returns>A formatted string grouping the seed values so they can
        /// be used according to the Spotify web API documentation.</returns>
        public static string GetSeedQuery(this IEnumerable<RecommendationSeed> seeds)
        {
            var genres = new List<string>();
            var artists = new List<string>();
            var albums = new List<string>();

            foreach (var seed in seeds)
            {
                switch (seed.Type)
                {
                    case RecommendationSeedType.Artist:
                        artists.Add(seed.Id);
                        break;

                    case RecommendationSeedType.Album:
                        albums.Add(seed.Id);
                        break;

                    case RecommendationSeedType.Genre:
                        genres.Add(seed.Id);
                        break;

                    default:
                        break;
                }
            }

            var stringBuilder = new StringBuilder();

            if (genres.Any())
            {
                stringBuilder.Append("&seed_genres=");
                stringBuilder.Append(string.Join(',', genres));
            }

            if (artists.Any())
            {
                stringBuilder.Append("&seed_artists=");
                stringBuilder.Append(string.Join(',', artists));
            }

            if (albums.Any())
            {
                stringBuilder.Append("&seed_albums=");
                stringBuilder.Append(string.Join(',', albums));
            }

            return stringBuilder.ToString();
        }
    }
}