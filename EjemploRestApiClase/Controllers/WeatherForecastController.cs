using EjemploRestApiClase;
using Microsoft.AspNetCore.Mvc;

namespace EjemploClaseWEBAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        //private static readonly string[] Summaries =
        //[
        //    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        //];

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            List<WeatherForecast> forecasts = new List<WeatherForecast>();
            for (int index = 1; index <= 5; index++)
            {
                forecasts.Add(new WeatherForecast
                {
                    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                    TemperatureC = Random.Shared.Next(-20, 55),
                    Humidity = Random.Shared.Next(0, 101),
                    // Summary se calcula automáticamente en la clase WeatherForecast
                });
            }
            return forecasts;
        }

    }
}
