using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
	public class MessageController : Controller
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


		public IActionResult SendBox()
		{
			Context c = new Context();
			var userName = User.Identity.Name;
			var mail = c.Users.FirstOrDefault(x => x.UserName == userName).Email;
			var id = c.Writers.FirstOrDefault(x => x.WriterMail == mail).WriterID;
			var values = mm.GetSendboxListByWriter(id);
			return View(values);
		}

		public IActionResult MessageDetails(int id)
		{
			var values = mm.GetById(id);
			return View(values);
		}

		public IActionResult SendMessage()
		{
			return View();
		}

		[HttpPost]
		public IActionResult SendMessage(Message2 m,string alicimail)
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

			m.SenderID = id;
			m.ReceiverID = aliciId;
			m.MessageStatus = true;
			m.MessageDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
			mm.TAdd(m);
			return RedirectToAction("Sendbox");
		}

	}
}
