using System;
using Greetings.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Greetings.API.Controllers
{
    [Route("api/[controller]")]
    public class GreetingsController : Controller
    {
        [HttpGet("{name}")]
        public IActionResult Get(string name)
        {
            Greeting g = new Greeting(name, Environment.MachineName, Environment.OSVersion.VersionString);

            return Ok(g);
        }
    }
}