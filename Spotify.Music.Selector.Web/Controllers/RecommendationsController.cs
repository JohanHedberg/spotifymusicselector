using Spotify.Music.Selector.Api;
using System.Threading.Tasks;
using System.Web.Http;

namespace Spotify.Music.Selector.Web.Controllers
{
    [Route("api/[controller]")]
    public class RecommendationsController : ApiController
    {
        private readonly SpotifyClient _spotifyClient;

        public RecommendationsController(SpotifyClient spotifyClient)
        {
            _spotifyClient = spotifyClient;
        }

        [HttpGet]
        public async Task<IHttpActionResult> Get()
        {
            if (string.IsNullOrEmpty(_spotifyClient.AuthorizationCode))
            {
                return Redirect(_spotifyClient.GetAuthenticationUri());
            }

            var recommendations = await _spotifyClient.GetRecommendations();

            return Ok(recommendations);
        }
    }
}