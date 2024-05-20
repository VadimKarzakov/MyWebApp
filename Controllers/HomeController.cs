using Microsoft.AspNetCore.Mvc;

namespace MyWebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var links = new
            {
                HealthCheck = Url.Action("Get", "HealthCheck", null, Request.Scheme),
                Item1 = Url.Action("Get", "Item1", null, Request.Scheme),
                Item2 = Url.Action("Get", "Item2", null, Request.Scheme)
            };

            return Ok(links);
        }
    }
}
