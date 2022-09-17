using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Xml.Linq;

namespace CoreDemo.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic1 : ViewComponent
    {
		BlogManager bm = new BlogManager(new EfBlogRepository());
		Context c = new Context();
		public IViewComponentResult Invoke()
		{
			ViewBag.BlogSayisi = bm.GetList().Count;
			ViewBag.MesajSayisi = c.Contacts.Count();
			ViewBag.YorumSayisi = c.Comments.Count();

			string api = "5c684b909c1f184cf07a83419a04d867";
			string connection = "https://api.openweathermap.org/data/2.5/weather?q=ankara&mode=xml&lang=tr&units=metric&appid=" + api;
			XDocument document = XDocument.Load(connection);
			ViewBag.v4 = document.Descendants("city").ElementAt(0).Attribute("name").Value;
			ViewBag.v5 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
			return View();
		}
	}
}
