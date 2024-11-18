using LeonardoNS.Client;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LeonardoNS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeonardoController : ControllerBase
    {
        private readonly LeonardoClient _client;

        public LeonardoController()
        {
            _client = new LeonardoClient();
        }

        [HttpGet("call")]
        public async Task<IActionResult> CallAPI()
        {
            
        }
    }
}
