using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CoreDemo.Models;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace CoreDemo.Controllers
{
	public class WriterController : Controller
	{
		WriterManager wm = new WriterManager(new EfWriterRepository());

		public IActionResult Index()
		{
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

		[AllowAnonymous]
		public IActionResult WriterEditProfile()
		{
			var writervalues = wm.GetById(1);
			return View(writervalues);
		}

		[AllowAnonymous]
		[HttpPost]
		public IActionResult WriterEditProfile(Writer p)
		{
			WriterValidator validator = new WriterValidator();
			ValidationResult result = validator.Validate(p);

			if (result.IsValid)
			{
				wm.TUpdate(p);
				return RedirectToAction("Index", "Dashboard");
			}

			foreach (var error in result.Errors)
			{
				ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
			}
			return View();
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
