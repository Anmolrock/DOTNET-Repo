using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class EmployeeController : Controller
    {
        public string EmployeeProfile(int id)
        {
            string profile = string.Empty;
            if(id == 1)
            {
                profile = "Employee 1 profile";
            }
            else if (id == 2)
            {
                profile = "Employee 2 profile";
            }
            else
            {
                profile = "No record found";
            }
            return profile;
        }
        public string Address(int id, string department)
        {
            return "id = " + id + " dept = " + department;
        }
    }
}
