using Entity.Context;
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

        public PartialViewResult MainPage()
        {
            //Sends Main Page Partial
            return PartialView();
        }


        //public IActionResult Deneme()
        //{
        //    var skill = db.Skills.ToList();
        //    return PartialView(skill);
        //}

      
    }
}
