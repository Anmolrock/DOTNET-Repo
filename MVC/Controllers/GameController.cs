using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class GameController : Controller
    {
        public string Name (string name)
        {
            return "Welcome to " + name;
        }
        public string FullName(string? first = "firstName" , string? last = "lastName")
        {
            return "Your first name is = " + first + " and last name is = " + last + "\n" + " Your first name is = " + first + "\n" + " Your last name is = " + last;
        }
    }
}
