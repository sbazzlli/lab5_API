using API_lab5.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_lab5.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MoodleController : ControllerBase
{
    private readonly IPersonService _service;

    public MoodleController(IPersonService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetMeMoodle(string login)
    {
       var response = await _service.GetPerson(login);
       return Ok(response);
    }
}
