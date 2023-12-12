using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
	public class AboutController : Controller
	{
		 
		public IActionResult Index()
		{
			using Context context = new Context();

			var abouts= context.Abouts.ToList();

			  return View(abouts);
		}
	}
}
