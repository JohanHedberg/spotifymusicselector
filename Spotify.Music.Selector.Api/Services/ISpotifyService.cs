using System.Collections.Generic;
using System.Threading.Tasks;

namespace Spotify.Music.Selector.Api.Services
{
    public interface ISpotifyService
    {
        bool RequiresAuthentication { get; }

        void SetAuthorizationCode(string code);

        Task<Album> GetAlbum();

        Task<Artist> GetArtist();

        string GetAuthenticationUri();

        Task<IEnumerable<string>> GetAvailableGenreSeeds();

        Task<RecommendationsResponse> GetRecommendations();

        Task<Track> GetTrack();
    }
}