using Microsoft.AspNetCore.Mvc;

namespace MVC2.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello Everone";
        }
        public string name()
        {
            return "My Name is Anmol";
        }
    }
}
