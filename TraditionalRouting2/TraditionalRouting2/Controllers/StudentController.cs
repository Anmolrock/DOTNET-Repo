using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TraditionalRouting2.Models;

namespace TraditionalRouting2.Controllers
{
    [RoutePrefix("students")]//common part yaha likhdo jisse baar baar nahi likhna padega

    public class StudentController : Controller
    {
        //[Route("students")] //Route banane ke liye ye karna hai
        [Route("")]
        public ActionResult GetAllStudents()
        {
            var students = Students();
            return View(students);
        }
        //[Route("students/{id}")]
        [Route("{id:int}")]
        public ActionResult GetStudent(int id)
        {
            var student = Students().FirstOrDefault(x => x.Id == id);
            return View(student);
        }
        //[Route("students/{id}/Address")]
        [Route("{id}/Address")]
        public ActionResult GetStudentAddress(int id)
        {
            var studentAddress = Students().Where(x => x.Id == id).Select(x => x.Address).FirstOrDefault();
            return View(studentAddress);
        }
        [Route("{id}")]
        public string MyString (string id)
        {
            return id;
        }
        [Route("~/about-us")]//~ sign se direct aboutus likhkar view dekh sakte hai prefix ke jarurat nahi padegi

        public string AboutUs()
        {
            return "This is about us";
        }
        private List<Student> Students()
        {
            return new List<Student>()
            {
                new Student()
                {
                    Id = 1,
                    Name = "Student",
                     Class = "First",
                    Address = new Address()
                    {
                        Address1 = "This is Student 1 Address",
                        City = "Student 1 city",
                        HomeNumber = "Student 1"
                    }
                 },
                new Student()
                {
                     Id = 2,
                    Name = "Student",
                     Class = "Second",
                    Address = new Address()
                    {
                        Address1 = "This is Student 2 Address",
                        City = "Student 2 city",
                        HomeNumber = "Student 2"
                     }
                 },
                 new Student()
                 {
                     Id = 3,
                     Name = "Student",
                      Class = "Third",
                     Address = new Address()
                     {
                         Address1 = "This is Student 3 Address",
                         City = "Student 3 city",
                         HomeNumber = "Student 3"
                     }
                 },
                 new Student()
                 {
                     Id = 4,
                     Name = "Student",
                      Class = "Fourth",
                     Address = new Address()
                     {
                         Address1 = "This is Student 4 Address",
                         City = "Student 4 city",
                         HomeNumber = "Student 4"
                     }
                 }
             };
        }
    }
}