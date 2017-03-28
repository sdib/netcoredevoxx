using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace netcorelive.Controllers.WheatherForecast
{
    [Route("api/[controller]")]
    public partial class SampleDataController : Controller
    {
        private readonly IDataService _dataService;
        private readonly ILogger<SampleDataController> _logger;

        public SampleDataController(IDataService dataService, ILogger<SampleDataController> logger){
            _dataService = dataService;
            _logger = logger;
        }

        [HttpGet("[action]")]
        public IEnumerable<WeatherForecast> WeatherForecasts(int startDateIndex)
        {
            _logger.LogInformation($"GET WeatherForecasts with startDateIndex {startDateIndex}");
            return _dataService.GetWeatherForecasts(startDateIndex);
        }

        [HttpGet("[action]")]
        public IEnumerable<WeatherForecast> Exception(int startDateIndex)
        {
            throw new ArgumentException("Need 1 argument");
        }
    }
}
