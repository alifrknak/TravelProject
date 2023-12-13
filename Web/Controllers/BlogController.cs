using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
	public class BlogController : Controller
	{
		Context _context = new Context();
		public IActionResult Index()
		{
			var blogs =_context.Blogs.ToList();

			return View(blogs);
		}
		public IActionResult BlogDetail(int blogId)
		{
			var blogs = _context.Blogs.Where(b => b.Id == blogId);

			return View(blogs);
		}
	}
}
