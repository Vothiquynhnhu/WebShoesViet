using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebShoes.Data;
using WebShoes.Models;

namespace WebShoes.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            //Slider-Home
            var SliderHomeQuery = _context.SliderHomes.FirstOrDefault(a => a.SliderName == "SliderHome1");
            ViewBag.SliderHome1 = SliderHomeQuery.SliderUrl1;
            ViewBag.SliderHome2 = SliderHomeQuery.SliderUrl2;
            ViewBag.SliderHome3 = SliderHomeQuery.SliderUrl3;
            ViewBag.SliderHome4 = SliderHomeQuery.SliderUrl4;
            ViewBag.SliderHome5 = SliderHomeQuery.SliderUrl5;
            return View();
        }

        public IActionResult Privacy()
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
