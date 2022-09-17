using CoreDemo.Areas.Admin.Models;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace CoreDemo.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class WriterController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult WriterList()
		{
			var jsonWriter = JsonConvert.SerializeObject(writers);
			return Json(jsonWriter);
		}

		[HttpPost]
		public IActionResult AddWriter(WriterClass p)
		{
			writers.Add(p);
			var jsonwriters = JsonConvert.SerializeObject(p);
			return Json(jsonwriters);
		}

		public IActionResult DeleteWriter(int id)
		{
			var writer = writers.FirstOrDefault(x => x.Id == id);
			writers.Remove(writer);
			return Json(writer);
		}

		public IActionResult UpdateWriter(WriterClass p)
		{
			var writer = writers.FirstOrDefault(x => x.Id == p.Id);
			writer.Name = p.Name;
			var jsonwriter = JsonConvert.SerializeObject(writer);
			return Json(jsonwriter);
		}

		public IActionResult GetWriterById(int id)
		{
			var findwriter = writers.FirstOrDefault(x => x.Id == id);
			var jsonwriter = JsonConvert.SerializeObject(findwriter);
			return Json(jsonwriter);
		}

		public static List<WriterClass> writers = new List<WriterClass>
		{
			new WriterClass
			{
				Id=1,
				Name="Tarık"
			},
			new WriterClass
			{
				Id=2,
				Name="Faruk"
			},
			new WriterClass
			{
				Id=3,
				Name="Ayşe"
			}
		};
	}
}
