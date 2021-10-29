using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CoreDemo.Controllers
{
	[AllowAnonymous]
	public class BlogController : Controller
	{
		BlogManager bm = new BlogManager(new EfBlogRepository());
		CategoryManager cm = new CategoryManager(new EfCategoryRepository());
		public IActionResult Index()
		{
			var values = bm.GetBlogListWithCategory();
			return View(values);
		}

		public IActionResult BlogReadAll(int id)
		{
			ViewBag.id = id;
			var values = bm.GetBlogByID(id);
			return View(values);
		}

		public IActionResult BlogListByWriter()
		{
			var values = bm.GetListWithCategoryByWriterBM(1);
			return View(values);
		}

		public IActionResult BlogAdd()
		{
			List<SelectListItem> categoryValues = (from x in cm.GetList()
												   select new SelectListItem
												   {
													   Text = x.CategoryName,
													   Value = x.CategoryID.ToString()
												   }).ToList();
			ViewBag.cv = categoryValues;
			return View();
		}

		[HttpPost]
		public IActionResult BlogAdd(Blog p)
		{
			BlogValidator validator = new BlogValidator();
			ValidationResult result = validator.Validate(p);

			if (result.IsValid)
			{
				p.BlogStatus = true;
				p.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
				p.WriterID = 1;
				bm.TAdd(p);
				return RedirectToAction("BlogListByWriter", "Blog");
			}

			foreach (var error in result.Errors)
			{
				ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
			}

			List<SelectListItem> categoryValues = (from x in cm.GetList()
												   select new SelectListItem
												   {
													   Text = x.CategoryName,
													   Value = x.CategoryID.ToString()
												   }).ToList();
			ViewBag.cv = categoryValues;
			return View();
		}

		public IActionResult DeleteBlog(int id)
		{
			var blogValue = bm.GetById(id);
			bm.TDelete(blogValue);
			return RedirectToAction("BlogListByWriter");
		}

		public IActionResult EditBlog(int id)
		{
			var blogValue = bm.GetById(id);

			List<SelectListItem> categoryValues = (from x in cm.GetList()
												   select new SelectListItem
												   {
													   Text = x.CategoryName,
													   Value = x.CategoryID.ToString()
												   }).ToList();
			ViewBag.cv = categoryValues;
			return View(blogValue);
		}


		[HttpPost]
		public IActionResult EditBlog(Blog p)
		{
			bm.TUpdate(p);
			return RedirectToAction("BlogListByWriter");
		}
	}
}
