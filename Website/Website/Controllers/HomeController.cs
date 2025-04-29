using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyApp.Db;
using MyApp.Db.DbOperations;
using MyApp.Models;
namespace Website.Controllers
{
    public class HomeController : Controller
    {

        CustomerRepository respository = null;

        public HomeController()
        {
            respository = new CustomerRepository();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult portfolio()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(CustomerModel model)
        {
            if (ModelState.IsValid)
            {
                int id = respository.AddCustomer(model);
                if (id > 0)
                {
                    ModelState.Clear();
                    ViewBag.Issucess = "Your message has been sent. Thank you!";
                }
            }
            return View("index");
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Login_tb objUser)
        {
            if(ModelState.IsValid)
            {
                using (mctcEntities db = new mctcEntities())
                {
                    var obj = db.Login_tb.Where(a=> a.UserName.Equals(objUser.UserName) && a.Password.Equals(objUser.Password)).FirstOrDefault();
                    if(obj != null)
                    {
                        Session["UserName"] = obj.UserName.ToString();
                        Session["Password"] = obj.Password.ToString();
                        return RedirectToAction("DashBoard");
                    }
                }
            }
            return View(objUser);
        }
        [HttpGet]
        public ActionResult DashBoard()
        {
            if (Session["UserName"]!= null)
            {
                mctcEntities db = new mctcEntities();
                var data = db.Contact_tb.ToList();
                ViewBag.userdetails = data;
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    }
}