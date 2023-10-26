using HurdosApp.Models.Data;

namespace HurdosApp.Services;

public interface IWeatherProvider
{
    Weather Get();
}
