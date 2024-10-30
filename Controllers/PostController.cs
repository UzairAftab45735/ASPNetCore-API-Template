using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetCore_API_Template.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        [HttpPost("ping")]
        public IActionResult Ping() 
        {
            return Ok("This is a POST API with status code 200.");
        }
    }
}
