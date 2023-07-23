using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    public class AdminAboutMeController : Controller
    {
        TravelContext travelContext = new TravelContext();
        public ActionResult Index()
        {
            var values = travelContext.AboutMes.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AdminAboutMeUpdate(int id)
        {
            var value = travelContext.AboutMes.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult AdminAboutMeUpdate(AboutMe p)
        {
            var value = travelContext.AboutMes.Find(p.AboutMeID);
            value.Title1 = p.Title1;
            value.Title2 = p.Title2;
            value.Description1 = p.Description1;
            value.Description2 = p.Description2;
            value.ImageUrl1 = p.ImageUrl1;
            value.ImageUrl2 = p.ImageUrl2;
            travelContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}