using Microsoft.AspNetCore.Mvc;

namespace CustomHelper.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
