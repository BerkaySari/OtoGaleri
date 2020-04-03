using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OtoGaleri.Service.UserService;

namespace OtoGaleri.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet("[action]")]
        public IActionResult Index()
        {
            return Ok();
        }

        [HttpGet("[action]")]
        public IActionResult Privacy()
        {
            return Ok();
        }

        [HttpGet("[action]")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return Ok();
        }
    }
}
