using Microsoft.AspNetCore.Mvc;

namespace MyWebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public ContentResult Get()
        {
            var baseUrl = $"{Request.Scheme}://{Request.Host}";

            var htmlContent = $@"
                <html>
                <head>
                    <title>Home</title>
                </head>
                <body>
                    <h1>Welcome to MyWebApp</h1>
                    <ul>
                        <li><a href='{baseUrl}/api/HealthCheck'>HealthCheck</a></li>
                        <li><a href='{baseUrl}/api/Item1'>Item1</a></li>
                        <li><a href='{baseUrl}/api/Item2'>Item2</a></li>
                    </ul>
                </body>
                </html>";

            return new ContentResult
            {
                ContentType = "text/html",
                Content = htmlContent
            };
        }
    }
}
