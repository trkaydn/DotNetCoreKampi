using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreDemo.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic2 : ViewComponent
	{
		Context c = new Context();
		public IViewComponentResult Invoke()
		{
			var lastAdded = c.Blogs.OrderByDescending(x => x.BlogID).FirstOrDefault();
			ViewBag.v1 = lastAdded.BlogTitle;
			ViewBag.v2 = c.Writers.FirstOrDefault(x => x.WriterID == lastAdded.WriterID).WriterName;
			return View();
		}
	}
    
}
