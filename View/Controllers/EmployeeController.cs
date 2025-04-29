using Microsoft.AspNetCore.Mvc;

namespace View.Controllers
{
	public class EmployeeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ViewResult AboutUs()
		{
			return View();
		}
	}
}
