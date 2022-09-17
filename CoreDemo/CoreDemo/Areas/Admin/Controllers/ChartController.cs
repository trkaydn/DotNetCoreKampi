using CoreDemo.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreDemo.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class ChartController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult CategoryChart()
		{
			List<CategoryClass> list = new();
			list.Add(new CategoryClass { CategoryName = "Teknoloji", CategoryCount = 10 });
			list.Add(new CategoryClass { CategoryName = "Yazılım", CategoryCount = 15 });
			list.Add(new CategoryClass { CategoryName = "Spor", CategoryCount = 20 });
			list.Add(new CategoryClass { CategoryName = "Sinema", CategoryCount = 5 });
			return Json(new {jsonlist = list });
		}
	}
}
