using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
	public class HomeController : Controller
	{
		Context _context = new Context();

		public IActionResult Index()
		{
			var blogs = _context.Blogs.ToList();

			return View(blogs);
		}
		public PartialViewResult GetPartialView()
		{
			var values = _context.Blogs.OrderByDescending(q => q.Id).Take(2).ToList();
			return PartialView(values);
		}
        
    }
}
