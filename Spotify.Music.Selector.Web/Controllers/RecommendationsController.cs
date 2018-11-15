using Microsoft.AspNetCore.Mvc;
using Spotify.Music.Selector.Api.Services;
using Spotify.Music.Selector.Web.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Spotify.Music.Selector.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecommendationsController : ControllerBase
    {
        private readonly ISpotifyService _spotifyService;

        public RecommendationsController(ISpotifyService spotifyService)
        {
            _spotifyService = spotifyService;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var recommendations = await _spotifyService.GetRecommendations();
            var models = recommendations.Tracks.Select(x => new Track(x));

            return Ok(models);
        }

        [HttpGet]
        public async Task<ActionResult> Seeds()
        {
            var seeds = await _spotifyService.GetAvailableGenreSeeds();

            return Ok(seeds);
        }
    }
}