using Microsoft.AspNetCore.Mvc;
using Spotify.Music.Selector.Api.Client;

namespace Spotify.Music.Selector.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISpotifyClient _spotifyClient;

        public HomeController(ISpotifyClient spotifyClient)
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

            return SinglePageApplication();
        }

        [HttpGet]
        [Route("callback")]
        public IActionResult Callback(string code, string state)
        {
            _spotifyClient.AuthorizationCode = code;

            return SinglePageApplication();
        }

        private IActionResult SinglePageApplication()
        {
            return LocalRedirect("~/ClientApp/build");
        }
    }
}