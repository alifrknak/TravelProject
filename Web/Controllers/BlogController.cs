using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
	public class BlogController : Controller
	{
		Context _context = new Context();
		public IActionResult Index()
		{
			var blogs = _context.Blogs.ToList();

			// The newest post has the smallest date.
			ViewData["recentPosts"] = _context.Blogs.Take(3).OrderBy(q => q.CreateTime);

			return View(blogs);
		}
		public IActionResult BlogDetail(int blogId)
		{
			var blogs = _context.Blogs.Single(b => b.Id == blogId);

			return View(blogs);
		}
	}
}
