using HurdosApp.Models.Data;

namespace HurdosApp.Services;

public class WeatherProvider : IWeatherProvider
{
    private readonly IEnumerable<string> _conditions = new [] {
        "ясно", "переменная облачность", "пасмурно",
        "дождь", "туман", "гроза", "снегопад"
    };

    public Weather Get()
    {
        var result = new Weather
        {
            DateTime = DateTime.Now,
            Temperature = Random.Shared.Next(-300, 400) / 10.0,
            WindSpeed = Random.Shared.Next(400) / 10.0,
            Conditions = _conditions.ElementAt(Random.Shared.Next(_conditions.Count())),
        };

        return result;
    }
}