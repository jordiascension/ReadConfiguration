using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace ReadConfiguration.Controllers
{
    public class HomeController : Controller
    {
        IConfiguration _configuration;
        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [Route("home/index")]
        public IActionResult Index()
        {
            ViewBag.connectionstring = _configuration["ConnectionStrings:DefaultConnection"];
            ViewBag.status = _configuration["status"];

            return View();
        }
    }
}