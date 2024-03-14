using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Chatty.Data
{
    // Serviciul pentru previziunile meteo
    public class WeatherForecastService
    {
        private readonly HttpClient _httpClient;

        // Constructor care initializează clientul HTTP
        public WeatherForecastService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // Metoda pentru obținerea previziunilor meteo pentru Chișinău, Moldova
        public async Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            // Adresa URL a API-ului de previziuni meteo
            var apiUrl = $"https://api.weatherapi.com/v1/forecast.json?key=my-api&q=Chisinau&days=5&aqi=no&alerts=no";

            // Cererea HTTP pentru a obține datele meteo de la API
            var response = await _httpClient.GetAsync(apiUrl);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Failed to fetch weather data. Status code: {response.StatusCode}");
            }

            // Citirea și parsarea răspunsului JSON
            using var responseStream = await response.Content.ReadAsStreamAsync();
            var forecastResponse = await JsonSerializer.DeserializeAsync<WeatherForecastApiResponse>(responseStream);

            // Construirea previziunilor meteo din răspunsul API
            var forecasts = new WeatherForecast[forecastResponse.Forecast.ForecastDay.Length];
            for (int i = 0; i < forecastResponse.Forecast.ForecastDay.Length; i++)
            {
                var forecast = forecastResponse.Forecast.ForecastDay[i].Day;
                forecasts[i] = new WeatherForecast
                {
                    Date = DateTime.Parse(forecastResponse.Forecast.ForecastDay[i].Date),
                    TemperatureC = (int)forecast.AvgTempC,
                    Summary = forecast.Condition.Text
                };
            }

            return forecasts;
        }
    }

    // Clasa pentru a deserializa răspunsul API-ului de previziuni meteo
    public class WeatherForecastApiResponse
    {
        public ForecastData Forecast { get; set; }
    }

    public class ForecastData
    {
        public ForecastDay[] ForecastDay { get; set; }
    }

    public class ForecastDay
    {
        public string Date { get; set; }
        public DayData Day { get; set; }
    }

    public class DayData
    {
        public double AvgTempC { get; set; }
        public ConditionData Condition { get; set; }
    }

    public class ConditionData
    {
        public string Text { get; set; }
    }
}
