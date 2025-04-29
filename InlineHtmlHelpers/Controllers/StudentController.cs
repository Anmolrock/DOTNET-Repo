using Microsoft.AspNetCore.Mvc;

namespace InlineHtmlHelpers.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index(string name)
        {
            return View();
        }
    }
}
