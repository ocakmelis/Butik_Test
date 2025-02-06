using Butik_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Butik_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    /*
     API katmaný servistir
    bilgileri JSON-XML vb formatýnda text olarak döner

     
     */
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        //[HttpGet(Name = "GetODEMEBILGISI")]
        //public bool GetOdemeinfo()
        //{
        //    return true;
        //}
        //[HttpGet(Name = "GetODEMEBILGISIv2")]
        //public IActionResult GetOdemeinfov2()
        //{

        //    return Ok();
        //}
    }
}
