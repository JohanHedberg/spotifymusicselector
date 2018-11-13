using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Spotify.Music.Selector.Api.Client
{
    public class SpotifyClient : ISpotifyClient
    {
        private readonly string _callbackUri;
        private readonly string _clientId;
        private readonly string _clientSecret;
        private readonly IHttpClientFactory _httpClientFactory;

        /// <summary>
        /// Gets or sets the authorization code used for fetching an
        /// authorization token from Spotify.
        /// </summary>
        public string AuthorizationCode { get; set; }

        /// <summary>
        /// Gets the access token provided by Spotify needed for consuming
        /// their WEB API.
        /// </summary>
        public string AccessToken { get; private set; }

        /// <summary>
        /// Creates an instance of a <see cref="SpotifyClient"/>.
        /// </summary>
        /// <param name="configuration">The configuration object holding the authentication details.</param>
        /// <param name="httpClientFactory">An <see cref="IHttpClientFactory"/> used for creating an HttpClient.</param>
        public SpotifyClient(
            IConfiguration configuration,
            IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;

            _callbackUri = configuration.GetValue<string>("Authentication:CallbackUri");
            _clientId = configuration.GetValue<string>("Authentication:ClientId");
            _clientSecret = configuration.GetValue<string>("Authentication:ClientSecret");
        }

        public async Task<Artist> GetArtist()
        {
            throw new NotImplementedException();
        }

        public async Task<Track> GetTrack()
        {
            throw new NotImplementedException();
        }

        public async Task<Album> GetAlbum()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a collection of all available genres that can be used for fetching recommendations.
        /// </summary>
        /// <returns>A collection of genres as strings.</returns>
        public async Task<IEnumerable<string>> GetAvailableGenreSeeds()
        {
            var client = _httpClientFactory.CreateClient();

            AccessToken = await GetAccessToken(client);

            var response = await client.GetAsync("https://api.spotify.com/v1/recommendations/available-genre-seeds?access_token={AccessToken}");

            if (response.StatusCode == HttpStatusCode.OK)
            {
                dynamic content = await response.Content.ReadAsAsync<IEnumerable<string>>();

                return content;
            }

            return new string[0];
        }

        public async Task<RecommendationsResponse> GetRecommendations()
        {
            var client = _httpClientFactory.CreateClient();

            AccessToken = await GetAccessToken(client);

            var fields = new Dictionary<string, string>
            {
                { "access_token", AccessToken},
                { "seed_genres", "blues" }
            };

            var response = await client.GetAsync("https://api.spotify.com/v1/recommendations?access_token={AccessToken}&seed_genres=blues");

            if (response.StatusCode == HttpStatusCode.OK)
            {
                dynamic content = await response.Content.ReadAsAsync<RecommendationsResponse>();

                return content;
            }

            return new RecommendationsResponse()
            {
                Tracks = Enumerable.Empty<Track>()
            };
        }

        public string GetAuthenticationUri()
        {
            var responseType = "code";
            return $"https://accounts.spotify.com/authorize?client_id={_clientId}&redirect_uri={_callbackUri}&response_type={responseType}";
        }

        /// <summary>
        /// Requests an access token from Spotify.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <returns></returns>
        public async Task<string> GetAccessToken(HttpClient httpClient)
        {
            var fields = new Dictionary<string, string>
            {
                { "grant_type", "authorization_code" },
                { "code", AuthorizationCode },
                { "redirect_uri", _callbackUri },
                { "client_id", _clientId },
                { "client_secret", _clientSecret },
            };

            var response = await httpClient
                .PostAsync("https://accounts.spotify.com/api/token", new FormUrlEncodedContent(fields));

            if (response.StatusCode == HttpStatusCode.OK)
            {
                dynamic content = await response.Content.ReadAsAsync<Authentication.AccessTokenResponse>();
                return content.Token;
            }

            return string.Empty;
        }
    }
}