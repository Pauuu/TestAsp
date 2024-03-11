using Microsoft.AspNetCore.Mvc;
using TestAsp.Services;

namespace TestAsp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IEmailSenderService _service;

        public WeatherForecastController(IEmailSenderService service)
        {
            _service = service;
        }

        [HttpGet ("caca", Name = "Culo")]
        public IEnumerable<WeatherForecast> Get()
        {
            _service.SendEmail("CULLO");
            return null;
        }

        [Route("Pipi")]
        [HttpGet]
        public string Pipi()
        {
            return "Pipi";
        }

    }
}