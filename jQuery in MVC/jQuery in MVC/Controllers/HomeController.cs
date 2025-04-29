using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using jQuery_in_MVC.Models;
using Newtonsoft.Json;
namespace jQuery_in_MVC.Controllers
    /* 1. Install jquery by using NUGET package
       2. Install Newtonsoft by using NUGET package for JSON File*/
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetStudent()
        {
            Student std = new Student()
            {
                Id = 1,
                Name = "Anmol",
                Email = "anmolupadhayay80@gmail.com",
            };
            var json = JsonConvert.SerializeObject(std);
            return Json(json,JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult AddStudent(Student student)
        {

            
            return Json("true",JsonRequestBehavior.AllowGet);
        }
    }
}