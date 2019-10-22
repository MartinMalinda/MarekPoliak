using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    [Route("api")]
    public class RestController : Controller
    {
        public static int IdCounter { get; set; } = 0;
        public Greeting greeting { get; set; } = new Greeting();
        public IActionResult Index()
        {
            return View();
        }

        [Route("greeting")]
        [HttpGet]
        public Greeting Greet()
        {
            Greeting greeting = new Greeting();
            IdCounter++;
            greeting.Id = IdCounter;
            greeting.Content = Request.Query["name"];

            return greeting;
        }
    }
}