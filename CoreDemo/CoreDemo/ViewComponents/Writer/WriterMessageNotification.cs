using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreDemo.ViewComponents.Writer
{
	public class WriterMessageNotification : ViewComponent
	{
		Message2Manager mm = new Message2Manager(new EfMessage2Repository());
		public IViewComponentResult Invoke()
		{
			Context c = new Context();
			var userName = User.Identity.Name;
			var mail = c.Users.FirstOrDefault(x => x.UserName == userName).Email;
			var id = c.Writers.FirstOrDefault(x => x.WriterMail == mail).WriterID;
			var values = mm.GetInboxListByWriter(id);
			return View(values);
		}
	}
}
