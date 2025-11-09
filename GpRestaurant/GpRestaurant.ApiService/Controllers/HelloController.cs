using Microsoft.AspNetCore.Mvc;

namespace GpRestaurant.ApiService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { Message = "Welcome to GpRestaurant API with .NET Aspire + Dapr!" });
        }
    }
}
