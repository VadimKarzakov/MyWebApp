using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;
using System.Collections.Generic;

namespace MyWebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Item2Controller : ControllerBase
    {
        private static List<Item2> items = new List<Item2>();

        // GET api/item2
        [HttpGet]
        public string Get()
        {
            return "Hello item2";
        }

        // POST api/item2
        [HttpPost]
        public void Post([FromBody] Item2 item)
        {
            items.Add(item);
        }
    }
}
