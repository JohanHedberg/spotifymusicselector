﻿using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Music.Selector.Api.Services
{
    /// <summary>
    /// Service used for communicating with the Spotify web api.
    /// </summary>
    public class SpotifyService : ISpotifyService
    {
        private string _authorizationCode;
        private readonly string _callbackUri;
        private readonly string _clientId;
        private readonly string _clientSecret;
        private readonly IHttpClientFactory _httpClientFactory;
        private Authorization.AccessToken _accessToken;

        /// <summary>
        /// Creates an instance of a <see cref="SpotifyService"/>.
        /// </summary>
        /// <param name="configuration">The configuration object holding the authentication details.</param>
        /// <param name="httpClientFactory">An <see cref="IHttpClientFactory"/> used for creating an HttpClient.</param>
        public SpotifyService(
            IConfiguration configuration,
            IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;

            _callbackUri = configuration.GetValue<string>("Authentication:CallbackUri");
            _clientId = configuration.GetValue<string>("Authentication:ClientId");
            _clientSecret = configuration.GetValue<string>("Authentication:ClientSecret");
        }

        public bool RequiresAuthentication => string.IsNullOrEmpty(_authorizationCode);

        /// <summary>
        /// Gets a collection of all available genres that can be used for fetching recommendations.
        /// </summary>
        /// <returns>A collection of genres as strings.</returns>
        public async Task<IEnumerable<string>> GetAvailableGenreSeeds()
        {
            var client = _httpClientFactory.CreateClient();

            _accessToken = await GetAccessToken(client);

            var response = await client.GetAsync($"https://api.spotify.com/v1/recommendations/available-genre-seeds?access_token={_accessToken.Token}");

            if (response.StatusCode == HttpStatusCode.OK)
            {
                dynamic content = await response.Content.ReadAsAsync<AvailableGenreSeedsResponse>();

                return content.Genres;
            }

            return new string[0];
        }

        public async Task<RecommendationsResponse> GetRecommendations(IEnumerable<RecommendationSeed> seeds)
        {
            var client = _httpClientFactory.CreateClient();

            _accessToken = await GetAccessToken(client);

            var response = await client.GetAsync($"https://api.spotify.com/v1/recommendations?access_token={_accessToken.Token}{GetSeedQuery(seeds)}");

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

        public string GetSeedQuery(IEnumerable<RecommendationSeed> seeds)
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

            //if (artists.Any())
            //{
            //    stringBuilder.Append("&seed_artists=");
            //    stringBuilder.Append(string.Join(',', artists));
            //}

            if (albums.Any())
            {
                stringBuilder.Append("&seed_albums=");
                stringBuilder.Append(string.Join(',', albums));
            }

            return stringBuilder.ToString();
        }

        public string GetAuthenticationUri()
        {
            var responseType = "code";
            return $"https://accounts.spotify.com/authorize?client_id={_clientId}&redirect_uri={_callbackUri}&response_type={responseType}";
        }

        public void SetAuthorizationCode(string code)
        {
            _authorizationCode = code;
            _accessToken = null;
        }

        /// <summary>
        /// Requests an access token from Spotify.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <returns></returns>
        public async Task<Authorization.AccessToken> GetAccessToken(HttpClient httpClient)
        {
            if (_accessToken != null && !_accessToken.HasExpired())
            {
                // If there is a token available already there is no need to make another roundtrip to Spotify
                // for fetching a new one.
                return _accessToken;
            }

            var fields = new Dictionary<string, string>
            {
                { "grant_type", "authorization_code" },
                { "code", _authorizationCode },
                { "redirect_uri", _callbackUri },
                { "client_id", _clientId },
                { "client_secret", _clientSecret },
            };

            var response = await httpClient
                .PostAsync("https://accounts.spotify.com/api/token", new FormUrlEncodedContent(fields));

            if (response.StatusCode == HttpStatusCode.OK)
            {
                dynamic content = await response.Content.ReadAsAsync<Authorization.AccessToken>();
                return content;
            }

            return null;
        }
    }
}