using Newtonsoft.Json;
using System;

namespace Spotify.Music.Selector.Api.Authorization
{
    /// <summary>
    /// Spotify access token used for authorization handshake
    /// between the consumer and the Spotify web API.
    /// </summary>
    public class AccessToken
    {
        private readonly DateTime _created;

        /// <summary>
        /// Initializes an instance of a new <see cref="AccessToken"/>.
        /// </summary>
        public AccessToken()
        {
            _created = DateTime.Now;
        }

        /// <summary>
        /// The token provided by Spotify.
        /// </summary>
        [JsonProperty(PropertyName ="access_token")]
        public string Token { get; set; }

        /// <summary>
        /// The token's type.
        /// </summary>
        [JsonProperty(PropertyName ="token_type")]
        public string TokenType { get; set; }

        /// <summary>
        /// The number of seconds in which the token will expire
        /// from the point it was created.
        /// </summary>
        [JsonProperty(PropertyName ="expires_in")]
        public int ExpiresIn { get; set; }

        /// <summary>
        /// Refresh token that can be used for extending the current
        /// authorized session with the Spotify web API.
        /// </summary>
        [JsonProperty(PropertyName ="refresh_token")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Optional string that can be used for extra security checks.
        /// </summary>
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