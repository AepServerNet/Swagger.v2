using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MVC_Swagger.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> logger;

        public HomeController(ILogger<HomeController> logger)
        {
            this.logger = logger;
        }

        [HttpGet("Welcome")]
        public IActionResult Welcome()
        {
            return Ok(string.Concat("Ciao sono le ore: ", DateTime.Now.ToShortTimeString()));
        }
    }
}