namespace EjemploClaseWEBAPI
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
        public int Humidity { get; set; } = 0;

        public string? Summary
        {
            get
            {
                return CalcularSummary();
            }
        }


        public WeatherForecast()
        {
        }
        public WeatherForecast(DateOnly date, int temperatureC, int humidity)
        {
            Date = date;
            TemperatureC = temperatureC;
            Humidity = humidity;
        }
        private string CalcularSummary() // Puede no ser static
        {
            // Regla de ejemplo de la diapositiva 27:
            if (TemperatureC > 30 && Humidity > 70)
            {
                return "Scorching";
            }
            else if (TemperatureC > 30 && Humidity <= 70)
            {
                return "Hot";
            }
            else if (TemperatureC >= 15 && TemperatureC <= 30)
            {
                return Humidity > 80 ? "Balmy" : "Warm";
            }
            else if (TemperatureC >= 0 && TemperatureC < 15)
            {
                return Humidity > 60 ? "Chilly" : "Cool";
            }
            else // TemperatureC < 0
            {
                return "Freezing";
            }
        }
    }
}
