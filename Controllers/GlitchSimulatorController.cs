using Microsoft.AspNetCore.Mvc;

namespace GlitchSimulator.Controllers;

[ApiController]
[Route("[controller]")]
public class GlitchController : ControllerBase
{
    [HttpGet]
    public IActionResult Get([FromQuery] int errorCode)
    {
        if (Enum.IsDefined(typeof(System.Net.HttpStatusCode), errorCode))
        {
            return StatusCode(errorCode);
        }

        return BadRequest("Invalid error code.");
    }
}
