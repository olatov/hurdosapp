using System.ComponentModel.DataAnnotations;

namespace HurdosApp.Models.Data;

public class Weather
{
    public DateTime DateTime { get; set; }

    public double Temperature { get; set; }

    public double WindSpeed { get; set; }

    public string Conditions { get; set;} = string.Empty;
}
