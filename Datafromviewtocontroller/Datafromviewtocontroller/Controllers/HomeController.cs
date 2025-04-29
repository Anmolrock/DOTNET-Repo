using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Datafromviewtocontroller.Models;

namespace Datafromviewtocontroller.Controllers
{
    /*Pass Data from View to Controller
      1. Using Parameters
      2. Using Requrest
      3. Using FormCollection
      4. Strongly Binding
      5. Using JS etc                */
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public string PostUsingParameters(string FirstName, string LastName)
        {

            return "From Parameters -"+ FirstName + ","+ LastName;
        }

        [HttpPost]
        public string PostUsingRequest()
        {
            string firstName = Request["FirstName"];
            string lastName = Request["LastName"];
            return "From Request -" + firstName + "," + lastName;
        }
        [HttpPost]
        public string PostUsingFormCollection(FormCollection form)
        {
            string firstName = form["FirstName"];
            string lastName = form["LastName"];
            return "From form collection -" + firstName + "," + lastName;
        }
        [HttpPost]
        public string PostUsingBinding(Employee emp)
        {
            
            return "From Strongly Binding  -" + emp.firstName + "," + emp.lastName;
        }
    }
}