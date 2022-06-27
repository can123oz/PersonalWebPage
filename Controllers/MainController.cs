using Entity.Context;
using Entity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioProject.Controllers
{
    public class MainController : Controller
    {
        DatabaseContext db = new DatabaseContext();

        public IActionResult Index()
        {
            var about = db.Abouts.FirstOrDefault();
            var contactForms = db.ContactForms.FirstOrDefault();
            var mainPages = db.MainPages.FirstOrDefault();
            var skills = db.Skills.ToList();
            var onePageTuple = (about, contactForms, mainPages, skills);
            return View(onePageTuple);
        }

        [HttpPost]
        public JsonResult ContactForm(ContactForm contactForm)
        {
            db.ContactForms.Add(contactForm);
            db.SaveChanges();
            return Json(contactForm);
        }
    }
}
