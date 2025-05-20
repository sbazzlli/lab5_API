using API_lab5.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_lab5.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CurrencyController : ControllerBase
{
    private readonly ICurrencyService _service;

    public CurrencyController(ICurrencyService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetCurrencyExchange(string _base, string _target)
    {
        var response = await _service.GetCurrencyRate(_base, _target);
        return Ok(response);
    }
}
