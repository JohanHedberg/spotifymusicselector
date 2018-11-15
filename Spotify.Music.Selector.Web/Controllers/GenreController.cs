using Microsoft.AspNetCore.Mvc;
using Spotify.Music.Selector.Api.Services;
using System.Threading.Tasks;

namespace Spotify.Music.Selector.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenreController : ControllerBase
    {
        private readonly ISpotifyService _spotifyService;

        public GenreController(ISpotifyService spotifyService)
        {
            _spotifyService = spotifyService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var seeds = await _spotifyService.GetAvailableGenreSeeds();

            return Ok(seeds);
        }
    }
}