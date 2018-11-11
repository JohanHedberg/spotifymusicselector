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
        private readonly HttpClient _httpClient;

        public string AccessToken { get; set; }

        public SpotifyClient(
            HttpClient httpClient,
            string callbackUri,
            string clientId,
            string clientSecret)
        {
            _httpClient = httpClient;
            _callbackUri = callbackUri;
            _clientId = clientId;
            _clientSecret = clientSecret;
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
            throw new NotImplementedException();
        }

        public async Task GetAuthorizationCode()
        {
            var responseType = "code";
            var response = await _httpClient
                .GetAsync($"https://accounts.spotify.com/authorize?client_id={_clientId}&redirect_uri={_callbackUri}&response_type={responseType}");

            if (response.StatusCode == HttpStatusCode.OK)
            {
                
            }
        }

        public async Task<string> GetAccessToken(string accessCode)
        {
            var fields = new Dictionary<string, string>
            {
                { "grant_type", "authorization_code" },
                { "code", accessCode },
                { "redirect_uri", _callbackUri },
                { "client_id", _clientId },
                { "client_secret", _clientSecret },
            };

            var response = await _httpClient
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