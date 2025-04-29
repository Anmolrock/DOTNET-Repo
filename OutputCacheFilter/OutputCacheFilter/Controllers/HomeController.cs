using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OutputCacheFilter.Controllers
{
    [OutputCache(Duration = 20, Location= 
        System.Web.UI.OutputCacheLocation.Client)]

    /*Output Cache Location:
      5 Location hoti hai OutputCache location ki
      (1)Any = 0
      (2)Client = 1
      (3)Downstream = 2
      (4)Server = 3
      (5)None = 4
      (6)Server and Client = 5*/
    public class HomeController : Controller
    {
        
        public ActionResult GetDate()
        {
            return View();
        }

    }
}