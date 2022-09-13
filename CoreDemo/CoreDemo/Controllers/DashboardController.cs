using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	public class DashboardController : Controller
	{
		BlogManager bm = new BlogManager(new EfBlogRepository());
		CategoryManager cm = new CategoryManager(new EfCategoryRepository());
		public IActionResult Index()
		{
			ViewBag.v1 = bm.GetList().Count;
			ViewBag.v2 = bm.GetBlogListByWriter(1).Count;
			ViewBag.v3 = cm.GetList().Count;
			return View();
		}
	}
}
