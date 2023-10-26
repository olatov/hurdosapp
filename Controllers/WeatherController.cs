using HurdosApp.Models;
using HurdosApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace HurdosApp.Controllers;

public class WeatherController : Controller
{
    private readonly IWeatherProvider _weatherProvider;

    public WeatherController(IWeatherProvider weatherProvider)
    {
        _weatherProvider = weatherProvider;
    }

    public IActionResult Index()
    {
        var viewModel = new WeatherViewModel
        {
            Weather = _weatherProvider.Get(),
        };

        return View(viewModel);
    }
}
