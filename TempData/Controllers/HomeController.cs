using Microsoft.AspNetCore.Mvc;

namespace TempData.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            TempData["Mykey"] = "Data from Index Method";
            return View();
        }
        public IActionResult Index2()
        {
            //ViewBag.MyKey = TempData["Mykey"];
            //TempData.Keep("Mykey");
            ViewBag.MyKey = TempData.Peek("Mykey");
            return View();
            /* 1. TempData() 2. TempData.Keep() 3. TempData.Peek() are 
             * 3 types */
        }
        public IActionResult Index3()
        {
            ViewBag.MyKey = TempData["Mykey"];
            return View();
        }
    }
}
