using Microsoft.AspNetCore.Mvc;
using StronglyTypeHelpers.Models;
using System.Security.Cryptography.X509Certificates;

namespace StronglyTypeHelpers.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Employee emp = new Employee()
            {
                Address = "Agra",
                Name = "Test",
                IsEmployee = true
            };
            return View(emp);
        }
        [HttpPost]
        public ActionResult Index(Employee emp)
        {
            return View(emp);
        }
    }
}
