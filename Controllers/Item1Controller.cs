using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;
using System.Collections.Generic;

namespace MyWebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Item1Controller : ControllerBase
    {
        private static List<Item1> items = new List<Item1>();

        // GET api/item1
        [HttpGet]
        public string Get()
        {
            return "Hello item1";
        }

        // POST api/item1
        public void Post([FromBody] Item1 item)
        {
            items.Add(item);
        }
    }
}
