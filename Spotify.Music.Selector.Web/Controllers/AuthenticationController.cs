using Spotify.Music.Selector.Web.Models;
using System.Threading.Tasks;
using System.Web.Http;

namespace Spotify.Music.Selector.Web.Controllers
{
    [Route("api/[controller]")]
    public class AuthenticationController : ApiController
    {
        public async Task<IHttpActionResult> Login(AuthenticationRequest request)
        {
            await Task.Run(() => null);

            return Ok();
        }

        public async Task<IHttpActionResult> Callback(string code, string state)
        {
            await Task.Run(() => null);

            return Ok();
        }
    }
}