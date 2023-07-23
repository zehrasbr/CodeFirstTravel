using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    public class DefaultController : Controller
    {
        TravelContext travelContext = new TravelContext();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            ViewBag.phone = travelContext.FooterContacts.Select(x => x.Phone).FirstOrDefault();

            return PartialView();
        }

        public PartialViewResult PartialNavbarScript()
        {
            return PartialView();
        }

        public PartialViewResult PartialFeature()
        {
            ViewBag.title = travelContext.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.description = travelContext.Abouts.Select(x => x.Description).FirstOrDefault();

            return PartialView();
        }

        [HttpGet]
        public PartialViewResult PartialHolidayPlan()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult PartialHolidayPlan(Booking p)
        {
            travelContext.Bookings.Add(p);
            travelContext.SaveChanges();
            return PartialView();
        }
        public PartialViewResult PartialPlace()
        {
            var values = travelContext.Places.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialDestination()
        {
           var values = travelContext.Destinations.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialExplore()
        {
            ViewBag.title = travelContext.Explores.Select(x => x.Title).FirstOrDefault();
            ViewBag.description = travelContext.Explores.Select(x => x.Description).FirstOrDefault();
            ViewBag.imageUrl = travelContext.Explores.Select(x => x.ImageUrl).FirstOrDefault();
            return PartialView();
        }

        public PartialViewResult PartialBookTravel()
        {
            return PartialView();
        }

        public PartialViewResult PartialFooter()
        {
            ViewBag.address = travelContext.FooterContacts.Select(x => x.Address).FirstOrDefault();
            ViewBag.phone = travelContext.FooterContacts.Select(x => x.Phone).FirstOrDefault();
            ViewBag.mail = travelContext.FooterContacts.Select(x => x.Mail).FirstOrDefault();
            return PartialView();
        }

        public PartialViewResult PartialSocialMedia()
        {
            var values = travelContext.SocialMedias.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialCategory()
        {
            var values = travelContext.Categories.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialGalery()
        {
            var values = travelContext.FooterGaleries.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialTravelTrip()
        {
            var values = travelContext.FooterTravelTrips.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
        public PartialViewResult Team()
        {
            return PartialView();
        }
        public PartialViewResult PartialFeature2()
        {
            return PartialView();
        }
    }
}