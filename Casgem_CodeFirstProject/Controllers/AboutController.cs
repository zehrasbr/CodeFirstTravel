using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    public class AboutController : Controller
    {
        TravelContext travelContext = new TravelContext();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
        public PartialViewResult PartialAboutMe()
        {
            ViewBag.title1 = travelContext.AboutMes.Select(x => x.Title1).FirstOrDefault();
            ViewBag.description1 = travelContext.AboutMes.Select(x => x.Description1).FirstOrDefault();
            ViewBag.imageUrl1 = travelContext.AboutMes.Select(x => x.ImageUrl1).FirstOrDefault();
            return PartialView();
        }
        public PartialViewResult PartialAboutMe2()
        {
            ViewBag.title2 = travelContext.AboutMes.Select(x => x.Title2).FirstOrDefault();
            ViewBag.description2 = travelContext.AboutMes.Select(x => x.Description2).FirstOrDefault();
            ViewBag.imageUrl2 = travelContext.AboutMes.Select(x => x.ImageUrl2).FirstOrDefault();
            return PartialView();
        }
        public PartialViewResult PartialGuide()
        {

            var guideSocialMediaList = travelContext.Guides
           .Include("SocialMedia")
           .ToList();

            return PartialView(guideSocialMediaList);

        }
        public PartialViewResult PartialMainPage()
        {
            return PartialView();
        }
    }
}