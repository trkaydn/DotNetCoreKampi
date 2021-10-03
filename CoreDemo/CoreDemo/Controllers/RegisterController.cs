using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CoreDemo.Models;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        RegisterCityViewModel viewModel;

        [HttpGet]
        public IActionResult Index()
        {
            viewModel = new RegisterCityViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Index(RegisterCityViewModel p)
        {
            WriterValidator validator = new WriterValidator();
            ValidationResult results = validator.Validate(p.Writer);

            if (results.IsValid)
            {
                wm.AddWriter(p.Writer);
                return RedirectToAction("Index", "Blog");
            }

            foreach (var error in results.Errors)
            {
                ModelState.AddModelError("Writer." + error.PropertyName, error.ErrorMessage);
            }
            return View(p);
        }
    }
}
