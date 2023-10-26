using HurdosApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace HurdosApp.Controllers.Api;

[ApiController]
[Route("api/weather")]
public class WeatherApiController : Controller
{
    private readonly IWeatherProvider _weatherProvider;

    public WeatherApiController(IWeatherProvider weatherProvider)
    {
        _weatherProvider = weatherProvider;
    }

    [HttpGet]
    [Route("")]
    public IActionResult Index()
    {
        var weather = _weatherProvider.Get();

        return Json(weather);
    }
}