using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace ASPNetCore_API_Template.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetController : ControllerBase
    {
        [HttpGet ("ping")]
        public IActionResult Ping() 
        {
            return Ok("This is a GET API with status code 200.");
        }
    }
}
