using Microsoft.AspNetCore.Mvc;
using TemplatedHTMLHelpers.Models;
namespace TemplatedHTMLHelpers.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Employee employee = new Employee()
            {
                Id = 1,
                Name = "Test",
                DateofBirth = DateTime.Now,
                Isonline = true,
                email = "anmol@gmail.com"
            };
            return View(employee);
        }
    }
}
