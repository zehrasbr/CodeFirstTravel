using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    public class AdminGuideController : Controller
    {
        TravelContext travelContext = new TravelContext();
        public ActionResult Index()
        {
            var values = travelContext.Guides.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddGuide()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddGuide(Guide p)
        {
            travelContext.Guides.Add(p);

            foreach (var socialMedia in p.SocialMedia)
            {
                travelContext.SocialMedias.Add(socialMedia);
            }

            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteGuide(int id)
        {
            var value = travelContext.Guides.Find(id);
            travelContext.Guides.Remove(value);
            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateGuide(int id)
        {
            var value = travelContext.Guides.Find(id);

            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateGuide(Guide p)
        {
            var value = travelContext.Guides.Find(p.GuideID);
            value.GuideName = p.GuideName;
            value.GuideTitle = p.GuideTitle;
            value.ImageUrl = p.ImageUrl;
            value.SocialMedia.Clear();
            value.SocialMedia.AddRange(p.SocialMedia);
            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}