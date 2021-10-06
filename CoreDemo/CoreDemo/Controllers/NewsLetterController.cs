using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CoreDemo.Controllers
{
    public class NewsLetterController : Controller
    {
        NewsLetterManager nm = new NewsLetterManager(new EfNewsLetterRepository());

        [HttpGet]
        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }

        [HttpPost]
        public JsonResult SubscribeMail(string mail)
        {
            if (!string.IsNullOrEmpty(mail) && new EmailAddressAttribute().IsValid(mail))
            {
                nm.AddNewsLetter(new NewsLetter()
                {
                    Mail = mail
                });

                return Json(1);
            }
            return Json(0);
        }
    }
}
