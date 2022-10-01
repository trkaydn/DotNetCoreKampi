using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CoreDemo.Models;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using JetBrains.Annotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
	public class WriterController : Controller
	{
		WriterManager wm = new WriterManager(new EfWriterRepository());

		private readonly UserManager<AppUser> _userManager;

		public WriterController(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}

		public IActionResult Index()
		{
			ViewBag.v2 = User.Identity.Name;
			return View();
		}
		public IActionResult WriterProfile()
		{
			return View();
		}
		public IActionResult WriterMail()
		{
			return View();
		}

		[AllowAnonymous]
		public IActionResult Test()
		{
			return View();
		}

		[AllowAnonymous]
		public PartialViewResult WriterNavbarPartial()
		{
			return PartialView();
		}

		[AllowAnonymous]
		public PartialViewResult WriterFooterPartial()
		{
			return PartialView();
		}

		//public IActionResult WriterEditProfile()
		//{
		//	Context c = new Context();
		//	var userName = User.Identity.Name;
		//	var id = c.Users.FirstOrDefault(x => x.UserName == userName).Id;
		//	UserManager userManager = new UserManager(new EfUserRepository());
		//	var values = userManager.GetById(id);
		//	return View(values);
		//}

		public async Task<IActionResult> WriterEditProfile()
		{
			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			UserUpdateViewModel model = new UserUpdateViewModel
			{
				ImageUrl = values.ImageUrl,
				NameSurname = values.NameSurname,
				Mail = values.Email,
				Password=null
			};
			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> WriterEditProfile(UserUpdateViewModel p)
		{

			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			values.Email = p.Mail;
			values.ImageUrl = p.ImageUrl;
			values.NameSurname = p.NameSurname;
			if (string.IsNullOrEmpty(p.Password))
				values.PasswordHash  = _userManager.PasswordHasher.HashPassword(values, p.Password);
			await _userManager.UpdateAsync(values);
			return RedirectToAction("Index", "Dashboard");
		}

		[AllowAnonymous]
		public IActionResult WriterAdd()
		{
			return View();
		}

		[AllowAnonymous]
		[HttpPost]
		public IActionResult WriterAdd(AddProfileImage p)
		{
			Writer w = new Writer()
			{
				WriterName = p.WriterName,
				WriterMail = p.WriterMail,
				WriterPassword = p.WriterPassword,
				WriterPasswordConfirm = p.WriterPasswordConfirm,
				WriterStatus = p.WriterStatus,
				WriterAbout = p.WriterAbout,
			};

			WriterValidator validator = new WriterValidator();
			ValidationResult result = validator.Validate(w);

			if (!result.IsValid)
			{

				foreach (var error in result.Errors)
				{
					ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
				}
				return View();

			}

			if (p.WriterImage != null)
			{
				var extension = Path.GetExtension(p.WriterImage.FileName);
				var newimagename = Guid.NewGuid() + extension;
				var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFiles/", newimagename);
				var stream = new FileStream(location, FileMode.Create);
				p.WriterImage.CopyTo(stream);
				w.WriterImage = "/WriterImageFiles/" + newimagename;
			}

			wm.TAdd(w);
			return RedirectToAction("Index", "Dashboard");
		}

	}
}
