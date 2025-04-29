using Microsoft.AspNetCore.Mvc;

namespace CustomHTMLHelper.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
