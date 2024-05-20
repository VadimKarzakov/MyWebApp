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

        [HttpGet]
        public string Get()
        {
            return "id1:Jamgo,id2:Smart,id3:Restin,id4:Man";
        }

        [HttpPost]
        public void Post([FromBody] Item1 item)
        {
            items.Add(item);
        }
    }
}
