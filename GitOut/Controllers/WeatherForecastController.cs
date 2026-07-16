using Microsoft.AspNetCore.Mvc;

namespace GitOut.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    [HttpGet]
    public IActionResult GetName()
    {
        // Replace with your real name
        return Ok(new { name = "Ethan Johnson" });
    }
}