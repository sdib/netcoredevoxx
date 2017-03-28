using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Options;

namespace netcorelive.Controllers.WheatherForecast
{
    public class MeteoFranceDataService : IDataService
    {
        private readonly MeteoFranceOptions _meteoFranceOptions;

        public MeteoFranceDataService(IOptions<MeteoFranceOptions> meteoFranceOptionsAccessor){
            _meteoFranceOptions = meteoFranceOptionsAccessor.Value;
        }
         private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

       public IEnumerable<WeatherForecast> GetWeatherForecasts(int startDateIndex)
       {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                DateFormatted = DateTime.Now.AddDays(index + startDateIndex).ToString("d"),
                TemperatureC = rng.Next(_meteoFranceOptions.TemperatureMinimum, _meteoFranceOptions.TemperatureMaximum),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });
       }

    }

}