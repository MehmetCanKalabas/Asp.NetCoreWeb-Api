using Asp.NetCoreWebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCoreWebApi.Controllers
{
    [ApiController]
    [Route("home")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetMessage()
        {
            var result = new ResponseModel()
            {
                HttpStatus = 200,
                Message = "Hello"
            };
            return Ok(result);
        }
    }
}
