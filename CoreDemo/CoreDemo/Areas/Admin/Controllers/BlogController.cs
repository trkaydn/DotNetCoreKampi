using BusinessLayer.Concrete;
using ClosedXML.Excel;
using CoreDemo.Areas.Admin.Models;
using DataAccessLayer.EntityFramework;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;

namespace CoreDemo.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class BlogController : Controller
	{
		BlogManager bm = new BlogManager(new EfBlogRepository());
		public IActionResult ExportStaticBlogList()
		{
			using (var workbook = new XLWorkbook())
			{
				var worksheet = workbook.Worksheets.Add("Blog Listesi");

				worksheet.Cell(1, 1).Value = "Blog ID";
				worksheet.Cell(1, 2).Value = "Blog Adı";

				int blogRowCount = 2;
				foreach (var item in GetBlogList())
				{
					worksheet.Cell(blogRowCount, 1).Value = item.ID;
					worksheet.Cell(blogRowCount, 2).Value = item.BlogName;
					blogRowCount++;
				}

				using(var stream = new MemoryStream())
				{
					workbook.SaveAs(stream);
					var content = stream.ToArray();
					return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "calisma1.xlsx");
				}

			}
			//return View();
		}

		public List<BlogModel> GetBlogList()
		{
			List<BlogModel> list = new List<BlogModel>
			{
				new BlogModel {ID=1, BlogName="test" },
				new BlogModel {ID=2, BlogName="test2" },
				new BlogModel {ID=3, BlogName="test3" },
			};
			return list;

		}

		public IActionResult BlogListExcel()
		{
			return View();
		}

		public IActionResult ExportDynamicBlogList()
		{
			using (var workbook = new XLWorkbook())
			{
				var worksheet = workbook.Worksheets.Add("Blog Listesi");

				worksheet.Cell(1, 1).Value = "Blog ID";
				worksheet.Cell(1, 2).Value = "Blog Adı";

				int blogRowCount = 2;
				foreach (var item in BlogTitleList())
				{
					worksheet.Cell(blogRowCount, 1).Value = item.ID;
					worksheet.Cell(blogRowCount, 2).Value = item.BlogName;
					blogRowCount++;
				}

				using (var stream = new MemoryStream())
				{
					workbook.SaveAs(stream);
					var content = stream.ToArray();
					return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "calisma1.xlsx");
				}

			}
		}

		public List<BlogModel2> BlogTitleList()
		{
			List<BlogModel2> list = new List<BlogModel2>();
			var values = bm.GetList();
			foreach(var item in values)
			{
				list.Add(new BlogModel2 { ID = item.BlogID, BlogName = item.BlogTitle });
			}
			return list;
		}

		public IActionResult BlogTitleListExcel()
		{
			return View();
		}
	}
}
