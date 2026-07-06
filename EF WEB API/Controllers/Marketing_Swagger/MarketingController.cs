using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EF_WEB_API.Controllers.Marketing_Swagger
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "marketing")]
    public class MarketingController : ControllerBase
    {
        [HttpGet("suma")]
        public int suma(int a, int b)
        {
            return a + b;

        }
    }
}
