using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetCore_API_Template.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PutController : ControllerBase
    {
        [HttpPut ("ping")]
        public IActionResult Ping()
        {
            return Ok("This is a PUT API with status code 200.");
        }
    }
}
