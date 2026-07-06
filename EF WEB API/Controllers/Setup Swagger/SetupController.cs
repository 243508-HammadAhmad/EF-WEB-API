using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EF_WEB_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiExplorerSettings(IgnoreApi =true)]
    public class SetupController : ControllerBase
    {
        [HttpGet("sumdouble")]
        public double sumdouble(double a, double b)
        {
            return a + b;

        }
    }
}


