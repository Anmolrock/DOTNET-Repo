using InlineHtmlHelpers.Models;
using Microsoft.AspNetCore.Mvc;

namespace InlineHtmlHelpers.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(UserModel um)
        {
            return View(um);
        }
    }
}
