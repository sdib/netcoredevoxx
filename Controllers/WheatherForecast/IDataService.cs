using System.Collections.Generic;

namespace netcorelive.Controllers.WheatherForecast
{
    public interface IDataService
    {
        IEnumerable<WeatherForecast> GetWeatherForecasts(int startDateIndex);

    }

}