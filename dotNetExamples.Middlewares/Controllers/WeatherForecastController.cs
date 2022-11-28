using Microsoft.AspNetCore.Mvc;

namespace dotNetExamples.Middlewares.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        public string Get()
        {
            throw new Exception("Hata");
        }
    }
}