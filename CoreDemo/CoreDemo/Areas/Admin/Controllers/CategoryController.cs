using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace CoreDemo.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class CategoryController : Controller
	{
		CategoryManager cm = new CategoryManager(new EfCategoryRepository());

		public IActionResult Index(int page = 1)
		{
			var values = cm.GetList().ToPagedList(page, 3);
			return View(values);
		}

		[HttpGet]
		public IActionResult AddCategory()
		{
			return View();
		}

		[HttpPost]
		public IActionResult AddCategory(Category p)
		{
			CategoryValidator validator = new CategoryValidator();
			ValidationResult result = validator.Validate(p);

			if (result.IsValid)
			{
				p.CategoryStatus = true;
				cm.TAdd(p);
				return RedirectToAction("Index", "Category");
			}

			foreach (var error in result.Errors)
			{
				ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
			}

			return View();
		}

		public IActionResult CategoryDelete(int id)
		{
			var categoryValue = cm.GetById(id);
			cm.TDelete(categoryValue);
			return RedirectToAction("Index");
		}

	}
}
