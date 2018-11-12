using Microsoft.AspNetCore.Mvc;
using Spotify.Music.Selector.Api;

namespace Spotify.Music.Selector.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly SpotifyClient _spotifyClient;

        public HomeController(SpotifyClient spotifyClient)
        {
            _spotifyClient = spotifyClient;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            if (string.IsNullOrEmpty(_spotifyClient.AuthorizationCode))
            {
                return Redirect(_spotifyClient.GetAuthenticationUri());
            }

            return Redirect("/ClientApp/build");
        }

        [HttpGet]
        [Route("callback")]
        public IActionResult Callback(string code, string state)
        {
            _spotifyClient.AuthorizationCode = code;

            return Redirect("/");
        }
    }
}