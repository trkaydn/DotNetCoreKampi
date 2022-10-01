using CoreDemo.Models;
using DocumentFormat.OpenXml.Office2010.Excel;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
	[Area("Admin")]
	[Authorize(Roles="Admin,Moderator")]
	public class AdminRoleController : Controller
	{
		private readonly RoleManager<AppRole> _roleManager;
		private readonly UserManager<AppUser> _userManager;

		public AdminRoleController(RoleManager<AppRole> roleManager, UserManager<AppUser> userManager)
		{
			_roleManager = roleManager;
			_userManager = userManager;
		}

		public IActionResult Index()
		{
			var values = _roleManager.Roles.ToList();
			return View(values);
		}

		public IActionResult AddRole()
		{
			return View();
		}
		public async Task<IActionResult> DeleteRole(int id)
		{
			var values = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
			var result = await _roleManager.DeleteAsync(values);
			return RedirectToAction("Index");
		}
		public IActionResult UpdateRole(int id)
		{
			var values = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
			RoleUpdateViewModel vm = new RoleUpdateViewModel() { Id = values.Id, Name = values.Name };
			return View(vm);
		}

		[HttpPost]
		public async Task<IActionResult> UpdateRole(RoleUpdateViewModel model)
		{
			var values = _roleManager.Roles.FirstOrDefault(x => x.Id == model.Id);
			values.Name = model.Name;
			var result = await _roleManager.UpdateAsync(values);

			if (result.Succeeded)
				return RedirectToAction("Index");
			else
				return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> AddRole(RoleViewModel m)
		{
			if (ModelState.IsValid)
			{
				AppRole r = new AppRole()
				{
					Name = m.Name
				};
				var result = await _roleManager.CreateAsync(r);
				if (result.Succeeded)
					return RedirectToAction("Index");

				foreach (var item in result.Errors)
					ModelState.AddModelError("", item.Description);
			}

			return View(m);
		}

		public IActionResult UserRoleList()
		{
			var values = _userManager.Users.ToList();
			return View(values);
		}

		public async Task<IActionResult> AssignRole(int id)
		{
			var user = _userManager.Users.FirstOrDefault(x => x.Id == id);
			var roles = _roleManager.Roles.ToList();
			TempData["Userid"] = user.Id;
			var userroles = await _userManager.GetRolesAsync(user);

			List<RoleAssignViewModel> vm = new List<RoleAssignViewModel>();

			foreach (var role in roles)
				vm.Add(new RoleAssignViewModel() { RoleId = role.Id, Name = role.Name, Exists = userroles.Contains(role.Name) });

			return View(vm);
		}

		[HttpPost]
		public async Task<IActionResult> AssignRole(List<RoleAssignViewModel> model)
		{
			var userId = (int)TempData["Userid"];
			var user = _userManager.Users.FirstOrDefault(x => x.Id == userId);

			foreach(var item in model)
			{
				if (item.Exists)
					await _userManager.AddToRoleAsync(user, item.Name);
				else
					await _userManager.RemoveFromRoleAsync(user, item.Name);
			}
			return RedirectToAction("UserRoleList");
		}
	}
}
