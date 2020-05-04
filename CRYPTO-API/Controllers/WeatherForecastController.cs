using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRYPTO_API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CRYPTO_API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly CyptoServicecs srv;
        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;

            srv = new CyptoServicecs();
        }

        [HttpGet]
        //[Route("get")]
        public IActionResult Get()
        {

            return Ok(srv.getTopCurrencies());
        }

        [HttpGet]
        //[Route("prueba")]

        public IActionResult prueba()
        {
            return new JsonResult("hola");
        }

    }
}
