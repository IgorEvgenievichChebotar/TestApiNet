using Microsoft.AspNetCore.Mvc;
using TestApiNet.Services;

namespace TestApiNet.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase
{
    private readonly PeopleService _peopleService;

    public PersonController(PeopleService peopleService)
    {
        _peopleService = peopleService;
    }

    [HttpGet]
    public IActionResult GetPeople()
    {
        return Ok(_peopleService.People);
    }
}