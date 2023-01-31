﻿using Microsoft.AspNetCore.Mvc;
using parkingvip.Models;
using System.Diagnostics;

namespace parkingvip.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
       
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult Services()
        {
            return View();
        }
        public IActionResult Contactenos()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [Route("error/404")]
        public IActionResult Error404() 
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}