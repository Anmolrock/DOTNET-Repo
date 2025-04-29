using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartialViewinMVC.Models;
namespace PartialViewinMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Employee> emp = new List<Employee>()
            {
                new Employee()
                {
                    Id= 1,
                    Email="anmol@gmail.com",
                    Name="Anmol Upadhyay",
                    Description = "This is 1 Description"
                },
                 new Employee()
                {
                    Id= 2,
                    Email="amit@gmail.com",
                    Name="Amit Kumar",
                    Description = "This is 2 Description"
                },
                  new Employee()
                {
                    Id= 3,
                    Email="rahul@gmail.com",
                    Name="rahul",
                    Description = "This is 3 Description"
                },
                   new Employee()
                {
                    Id= 4,
                    Email="suraj@gmail.com",
                    Name="suraj",
                    Description = "This is 4 Description"
                },
            };

            return View(emp);
        }
    }
}