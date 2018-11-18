using System.Collections.Generic;
using System.Threading.Tasks;

namespace Spotify.Music.Selector.Api.Services
{
    /// <summary>
    /// Service used for communication with Spotify.
    /// </summary>
    public interface ISpotifyService
    {
        /// <summary>
        /// Determines whether the user must login in to Spotify and
        /// grant the application access to their web API.
        /// </summary>
        bool RequiresAuthentication { get; }

        /// <summary>
        /// Sets the authorization code that is used for issueing an
        /// access token with Spotify.
        /// </summary>
        /// <param name="code">The authorization code provided by Spotify after
        /// the user has granted access.</param>
        void SetAuthorizationCode(string code);

        /// <summary>
        /// Gets the URI location where the user can login in and grant
        /// the application access to Spotify.
        /// </summary>
        /// <returns>The URI to the Spotify login page.</returns>
        string GetAuthenticationUri();

        /// <summary>
        /// Gets a collection of available genres that can be used for
        /// querying Spotify for recommendations.
        /// </summary>
        /// <returns>Available genres as a collection of strings.</returns>
        Task<IEnumerable<string>> GetAvailableGenreSeeds();

        /// <summary>
        /// Gets recommendations from Spotify based upon provided search criteria.
        /// </summary>
        /// <param name="seeds">Search criteria used for getting recommendations.</param>
        /// <returns>An <see cref="RecommendationsResponse"/> containing a collection
        /// of <see cref="Track"/>s recommended by Spotify.</returns>
        Task<RecommendationsResponse> GetRecommendations(IEnumerable<RecommendationSeed> seeds);
    }
}