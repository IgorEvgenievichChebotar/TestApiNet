using Microsoft.AspNetCore.Mvc;
using TestApiNet.Services;

namespace TestApiNet.Controllers;

[ApiController]
[Route("[controller]")]
public class ChildController : ControllerBase
{
    private readonly ChildService _childService;

    public ChildController(ChildService childService)
    {
        _childService = childService;
    }

    [HttpGet]
    public IActionResult GetChildren()
    {
        return Ok(_childService.Children);
    }
}