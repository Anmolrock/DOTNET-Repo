using Microsoft.AspNetCore.Mvc;
using MODEL.Models;

namespace MODEL.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var data = GetEmployee();
            return View(data);
        }
        
        private Employee GetEmployee()
        {
            return new Employee()
            {
                Id = 1,
                Address = "India",
                Name = "WebGentle"
            };
        }
    }
}
