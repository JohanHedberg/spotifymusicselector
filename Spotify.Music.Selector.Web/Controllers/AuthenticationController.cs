using Spotify.Music.Selector.Api;
using Spotify.Music.Selector.Web.Models;
using System.Threading.Tasks;
using System.Web.Http;

namespace Spotify.Music.Selector.Web.Controllers
{
    [Route("api/[controller]")]
    public class AuthenticationController : ApiController
    {
        private readonly SpotifyClient _spotifyClient;

        public AuthenticationController(SpotifyClient spotifyClient)
        {
            _spotifyClient = spotifyClient;
        }

        public async Task<IHttpActionResult> Login(AuthenticationRequest request)
        {
            await Task.Run(() => null);

            return Ok();
        }

        public async Task<IHttpActionResult> Callback(string code, string state)
        {
            await Task.Run(() => _spotifyClient.AuthorizationCode = code);

            return Redirect("./");
        }
    }
}