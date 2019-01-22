using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace heathinvestigations.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        [HttpGet("")]
        [Route("Home")]
        public IActionResult Index()
        {
            return View("Index");
        }
        
        [HttpGet("Services")]
        public IActionResult Services()
        {
            return View("Services");
        }

        [HttpGet("Investigative-Highlights")]
        public IActionResult Highlights()
        {
            return View("Highlights");
        }

        [HttpGet("Contact")]
        public IActionResult Contact()
        {
            return View("Contact");
        }
    }
}
