using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello from mctc";
        }
        public string Name()
        {
            return "My name is Anmol";
        }
    }
}
