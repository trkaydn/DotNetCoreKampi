using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace CoreDemo.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class AdminMessageController : Controller
	{
		Message2Manager mm = new Message2Manager(new EfMessage2Repository());

		public IActionResult Inbox()
		{
			Context c = new Context();
			var userName = User.Identity.Name;
			var mail = c.Users.FirstOrDefault(x => x.UserName == userName).Email;
			var id = c.Writers.FirstOrDefault(x => x.WriterMail == mail).WriterID;
			var values = mm.GetInboxListByWriter(id);
			return View(values);
		}

		public IActionResult Sendbox()
		{
			Context c = new Context();
			var userName = User.Identity.Name;
			var mail = c.Users.FirstOrDefault(x => x.UserName == userName).Email;
			var id = c.Writers.FirstOrDefault(x => x.WriterMail == mail).WriterID;
			var values = mm.GetSendboxListByWriter(id);
			return View(values);
		}

		public IActionResult ComposeMessage()
		{
			return View();
		}
		[HttpPost]
		public IActionResult ComposeMessage(string subject,string detail,string alicimail)
		{
			Context c = new Context();
			var userName = User.Identity.Name;
			var mail = c.Users.FirstOrDefault(x => x.UserName == userName).Email;
			var id = c.Writers.FirstOrDefault(x => x.WriterMail == mail).WriterID;

			int aliciId = 0;

			if (c.Writers.FirstOrDefault(x => x.WriterMail == alicimail) != null)
				aliciId = c.Writers.FirstOrDefault(x => x.WriterMail == alicimail).WriterID;

			else if (c.Users.FirstOrDefault(x => x.Email == alicimail) != null)
				aliciId = c.Users.FirstOrDefault(x => x.Email == alicimail).Id;

			var p = new Message2();
			p.SenderID = id;
			p.ReceiverID = aliciId;
			p.MessageStatus = true;
			p.Subject = subject;
			p.MessageDetails = detail;
			p.MessageDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
			mm.TAdd(p);
			return RedirectToAction("Sendbox");
		}
	}
}
