using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Writer
{
	public class WriterAboutOnDashboard : ViewComponent
	{
		WriterManager wm = new WriterManager(new EfWriterRepository());
		private readonly UserManager<AppUser> _userManager;

		public WriterAboutOnDashboard(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}

		public IViewComponentResult Invoke()
		{
			var username = User.Identity.Name;
			Context c = new Context();
			var userMail = c.Users.FirstOrDefault(x => x.UserName == username).Email;
			var writerID = c.Writers.FirstOrDefault(x => x.WriterMail == userMail).WriterID;
			var values = wm.GetWritersById(writerID);
			return View(values);
		}
	}
}
