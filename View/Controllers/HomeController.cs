using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using View.Models;

namespace View.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ActionResult Index()
        {
            return View();
        }
        public ViewResult AboutUs()
        {
            return View();
        }
    }
}