using Microsoft.AspNetCore.Mvc;
using Spotify.Music.Selector.Api.Services;
using Spotify.Music.Selector.Web.Models;
using System.Collections.Generic;
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
        public async Task<ActionResult> Get(string genre, string artistId)
        {
            var seeds = new List<Api.RecommendationSeed>();

            if (!string.IsNullOrEmpty(genre))
            {
                seeds.Add(new Api.RecommendationSeed { Type = Api.RecommendationSeedType.Genre, Id = genre });
            }

            if (!string.IsNullOrEmpty(artistId))
            {
                seeds.Add(new Api.RecommendationSeed { Type = Api.RecommendationSeedType.Artist, Id = artistId });
            }

            var recommendations = await _spotifyService.GetRecommendations(seeds);

            var models = recommendations.Tracks.Select(x => new Track(x));

            return Ok(models);
        }
    }
}