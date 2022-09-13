using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreDemo.ViewComponents.Writer
{
	public class WriterAboutOnDashboard : ViewComponent
	{
		WriterManager wm = new WriterManager(new EfWriterRepository());
		public IViewComponentResult Invoke()
		{
			var userMail = User.Identity.Name;
			Context c = new Context();
			var writerID = c.Writers.FirstOrDefault(x => x.WriterMail == userMail).WriterID;
			var values = wm.GetWritersById(writerID);
			return View(values);
		}
	}
}
