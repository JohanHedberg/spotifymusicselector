using Spotify.Music.Selector.Api;
using System.Threading.Tasks;
using System.Web.Http;

namespace Spotify.Music.Selector.Web.Controllers
{
    [Route("api/[controller]")]
    public class MusicController : ApiController
    {
        private readonly SpotifyClient _spotifyClient;

        public MusicController(SpotifyClient spotifyClient)
        {
            _spotifyClient = spotifyClient;
        }

        public async Task<IHttpActionResult> GetTrack()
        {
            var track = await _spotifyClient.GetTrack();

            return Ok(track);
        }
    }
}