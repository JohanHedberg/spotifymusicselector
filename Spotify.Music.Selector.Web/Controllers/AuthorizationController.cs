using Microsoft.AspNetCore.Mvc;
using Spotify.Music.Selector.Api.Services;

namespace Spotify.Music.Selector.Web.Controllers
{
    public class AuthorizationController : Controller
    {
        private readonly ISpotifyService _spotifyService;

        public AuthorizationController(ISpotifyService spotifyService)
        {
            _spotifyService = spotifyService;
        }

        [HttpGet]
        [Route("callback")]
        public IActionResult Callback(string code, string state)
        {
            _spotifyService.SetAuthorizationCode(code);

            // Now that we have an auhtorization code stored we can
            // redirect to the root to load the SPA front-end client.
            return LocalRedirect("/");
        }
    }
}