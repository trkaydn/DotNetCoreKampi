using CoreDemo.Models;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
	[AllowAnonymous]
	public class LoginController : Controller
	{
		private readonly SignInManager<AppUser> _signInManager;

		public LoginController(SignInManager<AppUser> signInManager)
		{
			_signInManager = signInManager;
		}

		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Index(UserSignInViewModel p)
		{
			if (ModelState.IsValid)
			{
				var result = await _signInManager.PasswordSignInAsync(p.UserName, p.Password, false, true);
				if (result.Succeeded)
					return RedirectToAction("Index", "Dashboard");
			}
			return View();
		}

		//[HttpPost]
		//public async Task<IActionResult> Index(Writer p)
		//{
		//	Context c = new Context();
		//	var values = c.Writers.FirstOrDefault(x => x.WriterMail == p.WriterMail && x.WriterPassword == p.WriterPassword);

		//	if (values != null)
		//	{
		//		var claims = new List<Claim>()
		//		{
		//			new Claim(ClaimTypes.Name,p.WriterMail)
		//		};
		//		var useridentity = new ClaimsIdentity(claims, "a");
		//		ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
		//		await HttpContext.SignInAsync(principal);

		//		return RedirectToAction("Index", "Dashboard");
		//	}

		//	return View();
		//}


		public async Task<IActionResult> Logout()
		{
			await _signInManager.SignOutAsync();
			return RedirectToAction("Index");
		}

		public IActionResult AccessDenied()
		{
			return View();
		}
	}
}