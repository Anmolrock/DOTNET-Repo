using Microsoft.AspNetCore.Mvc;
using ViewBag.Models;
namespace ViewBag.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.MyCustomProperty = "Hi, Anmol, How are your";

            ViewBag.Mylist = new List<string>() { "John", "Mark", "David", "Carol", "Francis" };

            List<Employee> emplist = new List<Employee>()
            {
                new Employee() { Id = 1,Name = "John", Email = "a@gmail.com"},
                new Employee() { Id = 2,Name = "David", Email = "b@gmail.com"},
                new Employee() { Id = 3,Name = "eric", Email = "c@gmail.com"},
                new Employee() { Id = 4,Name = "gail", Email = "d@gmail.com"},
                new Employee() { Id = 5,Name = "bob", Email = "e@gmail.com"},
                new Employee() { Id = 6,Name = "carol", Email = "f@gmail.com"}
            };
            ViewBag.Emplist = emplist;
            return View();
        }

        public ActionResult Demo()
        {
            ViewData["MyKey"] = "This is value for my Key";
            
            ViewData["Mylist"]= new List<string>() { "John", "Mark", "David", "Carol", "Francis" };

            return View();
        }
    }
}
