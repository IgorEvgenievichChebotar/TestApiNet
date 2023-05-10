using Microsoft.AspNetCore.Mvc;

namespace TestApiNet.Controllers;

[ApiController]
[Route("[controller]")]
public class HealthCheckController : ControllerBase
{
    [HttpGet]
    public IActionResult Check()
    {
        return Ok(new
        {
            message = "Работаем, братья"
        });
    }
}