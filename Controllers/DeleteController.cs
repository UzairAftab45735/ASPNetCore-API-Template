using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetCore_API_Template.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeleteController : ControllerBase
    {
        [HttpDelete("ping")]
        public IActionResult Ping()
        {
            return Ok("This is a DELETE API with status code 200.");
        }
    }
}
