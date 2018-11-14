using Newtonsoft.Json;
using System;

namespace Spotify.Music.Selector.Api.Authorization
{
    public class AccessToken
    {
        private readonly DateTime _created;

        public AccessToken()
        {
            _created = DateTime.Now;
        }

        [JsonProperty(PropertyName ="access_token")]
        public string Token { get; set; }

        [JsonProperty(PropertyName ="token_type")]
        public string TokenType { get; set; }

        [JsonProperty(PropertyName ="expires_in")]
        public int ExpiresIn { get; set; }

        [JsonProperty(PropertyName ="refresh_token")]
        public string RefreshToken { get; set; }

        [JsonProperty(PropertyName = "scope")]
        public string Scope { get; set; }

        /// <summary>
        /// Gets if this token has been expired and woudl require for a new 
        /// one to be fetched from Spotify.
        /// </summary>
        /// <returns>True if the token has expired, else returns false.</returns>
        public bool HasExpired()
        {
            return DateTime.Now >= _created.AddSeconds(ExpiresIn);
        }
    }
}