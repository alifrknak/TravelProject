using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
	public class BlogController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
