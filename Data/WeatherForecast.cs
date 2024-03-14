using System;

namespace Chatty.Data
{
    // Clasa pentru previziunile meteo
    public class WeatherForecast
    {
        // Data previziunii
        public DateTime Date { get; set; }

        // Temperatura în grade Celsius
        public int TemperatureC { get; set; }

        // Convertirea temperaturii în grade Fahrenheit
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        // Rezumatul previziunii
        public string Summary { get; set; }
    }
}
