using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace EF_WEB_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        [HttpGet ("suma")]
        public int suma(int a,int b)
        {
            return a + b;

        }
        
    }
}
