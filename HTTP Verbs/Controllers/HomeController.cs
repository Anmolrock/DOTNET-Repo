using Microsoft.AspNetCore.Mvc;
using HTTP_Verbs.Models;
namespace HTTP_Verbs.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Profile(int id)
        {
            /* HTTP Verbs or Methods are mainly 4 types
             * 1. GET
             * 2. Post
             * 3. Put
             * 4. Delete 
             HTTP verbs are used on a action method*/

            return View();
        }
        [HttpPost]
        
        public ActionResult CreateProfile(Student student)
        {
            //
            return View();
        }
        [HttpPut]
        public ActionResult UpdateProfile(int id, Student student)
        {
            //
            return View();
        }
        [HttpDelete]
        public ActionResult DeleteProfile(int id)
        {
            return View();
        }

    }
}
