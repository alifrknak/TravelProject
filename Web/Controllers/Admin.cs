using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
	public class Admin : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
