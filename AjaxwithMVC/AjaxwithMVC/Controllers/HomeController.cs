using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxwithMVC.Models;
using Newtonsoft.Json;


namespace AjaxwithMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Index(Employee model)
        {
            return Json(model, JsonRequestBehavior.AllowGet);

        }
        public ActionResult List()
        {
            return View();
        }

        public JsonResult Countries()
        {
            List<string> countries = new List<string>()
            {
                "Countries -- Afghanistan"
                ,"Countries -- Albania"
                ,"Countries -- Algeria"
                ,"Countries -- Andorra"
                ,"Countries -- Angola"
                ,"Countries -- Antigua and Barbuda"
                ,"Countries -- Argentina"
                ,"Countries -- Armenia"
                ,"Countries -- Australia"
                ,"Countries -- Austria"
                ,"Countries -- Azerbaijan"
            };
            var json = JsonConvert.SerializeObject(countries);
            return Json(json,JsonRequestBehavior.AllowGet);
        }
        public JsonResult States()
        {
            List<string> States = new List<string>()
            {
                "State -- Afghanistan"
                ,"State -- Albania"
                ,"State -- Algeria"
                ,"State -- Andorra"
                ,"State -- Angola"
                ,"State -- Antigua and Barbuda"
                ,"State -- Argentina"
                ,"State -- Armenia"
                ,"State -- Australia"
                ,"State -- Austria"
                ,"State -- Azerbaijan"
            };
            var json = JsonConvert.SerializeObject(States);
            return Json(json, JsonRequestBehavior.AllowGet);
        }
        public JsonResult City()
        {
            List<string> city = new List<string>()
            {
                "City -- Afghanistan"
                ,"City -- Albania"
                ,"City -- Algeria"
                ,"City -- Andorra"
                ,"City -- Angola"
                ,"City -- Antigua and Barbuda"
                ,"City -- Argentina"
                ,"City -- Armenia"
                ,"City -- Australia"
                ,"City -- Austria"
                ,"City -- Azerbaijan"
            };
            var json = JsonConvert.SerializeObject(city);
            return Json(json, JsonRequestBehavior.AllowGet);
        }
    }
}