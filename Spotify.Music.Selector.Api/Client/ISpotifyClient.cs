using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Spotify.Music.Selector.Api.Client
{
    public interface ISpotifyClient
    {
        string AccessToken { get; }

        string AuthorizationCode { get; set; }

        Task<string> GetAccessToken(HttpClient httpClient);

        Task<Album> GetAlbum();

        Task<Artist> GetArtist();

        string GetAuthenticationUri();

        Task<IEnumerable<string>> GetAvailableGenreSeeds();

        Task<RecommendationsResponse> GetRecommendations();

        Task<Track> GetTrack();
    }
}