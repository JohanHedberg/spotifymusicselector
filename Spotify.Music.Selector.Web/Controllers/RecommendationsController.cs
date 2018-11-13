using Microsoft.AspNetCore.Mvc;
using Spotify.Music.Selector.Api.Client;
using System.Threading.Tasks;

namespace Spotify.Music.Selector.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecommendationsController : ControllerBase
    {
        private readonly ISpotifyClient _spotifyClient;

        public RecommendationsController(ISpotifyClient spotifyClient)
        {
            _spotifyClient = spotifyClient;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var recommendations = await _spotifyClient.GetRecommendations();

            return Ok(recommendations);
        }
    }
}