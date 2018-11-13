using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Spotify.Music.Selector.Api
{
    public class SpotifyClient
    {
        private readonly string _callbackUri;
        private readonly string _clientId;
        private readonly string _clientSecret;
        private readonly IHttpClientFactory _httpClientFactory;

        public string AuthorizationCode { get; set; }

        public string AccessToken { get; set; }

        public SpotifyClient(
            IHostingEnvironment hostingEnvironment,
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

        public async Task<RecommendationCollection> GetRecommendations()
        {
            var client = _httpClientFactory.CreateClient();
            var recommendations = new RecommendationCollection();

            var fields = new Dictionary<string, string>
            {
                { "access_token", AccessToken},
                { "seed_genres", "blues" }
            };

            var response = await client.GetAsync("https://api.spotify.com/v1/recommendations");

            if (response.StatusCode == HttpStatusCode.OK)
            {
                //var content = await response.Content.ReadAsStringAsync();
                //return content;
            }

            return recommendations;
        }

        public async Task GetAuthorizationCode()
        {
            var client = _httpClientFactory.CreateClient();
            var responseType = "code";
            var response = await client
                .GetAsync($"https://accounts.spotify.com/authorize?client_id={_clientId}&redirect_uri={_callbackUri}&response_type={responseType}");

            if (response.StatusCode == HttpStatusCode.OK)
            {
                AuthorizationCode = await response.Content.ReadAsStringAsync();
            }
        }

        public string GetAuthenticationUri()
        {
            var responseType = "code";
            return $"https://accounts.spotify.com/authorize?client_id={_clientId}&redirect_uri={_callbackUri}&response_type={responseType}";
        }

        public async Task<string> GetAccessToken(string accessCode)
        {
            var client = _httpClientFactory.CreateClient();
            var fields = new Dictionary<string, string>
            {
                { "grant_type", "authorization_code" },
                { "code", AuthorizationCode },
                { "redirect_uri", _callbackUri },
                { "client_id", _clientId },
                { "client_secret", _clientSecret },
            };

            var response = await client
                .PostAsync("https://accounts.spotify.com/api/token", new FormUrlEncodedContent(fields));

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var content = await response.Content.ReadAsStringAsync();
                return content;
            }

            return string.Empty;
        }
    }
}