using Microsoft.AspNetCore.Mvc;

namespace MVC2.Controllers
{
    public class EmployeeController : Controller
    {
        public string EmployeeProfile(int id)
        {
            string profile = string.Empty;
            if (id == 1)
            {
                profile = "Employee 1 Profile";
            }
            else
            {
                profile = "No Record Found";
            }
            return "Profile";
        }
    }
}
