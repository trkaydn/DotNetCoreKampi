using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreDemo.Controllers
{
	public class DashboardController : Controller
	{
		BlogManager bm = new BlogManager(new EfBlogRepository());
		CategoryManager cm = new CategoryManager(new EfCategoryRepository());
		public IActionResult Index()
		{
			ViewBag.v1 = bm.GetList().Count;
			Context c = new Context();
			ViewBag.UserName = User.Identity.Name;
			var userMail = c.Users.FirstOrDefault(x => x.UserName == User.Identity.Name).Email;
			var writerID = c.Writers.FirstOrDefault(x => x.WriterMail == userMail).WriterID;
			ViewBag.v2 = bm.GetBlogListByWriter(writerID).Count;
			ViewBag.v3 = cm.GetList().Count;
			return View();
		}
	}
}
