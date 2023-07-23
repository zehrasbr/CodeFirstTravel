using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    public class ContactController : Controller
    {
        TravelContext travelContext = new TravelContext();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Contact p)
        {
            travelContext.Contacts.Add(p);
            p.MessageDate = DateTime.Parse(DateTime.Now.ToString("dd-MM-yyyy"));
            travelContext.SaveChanges();

            return RedirectToAction("Index", "Default");
        }
        public PartialViewResult PartialDetail()
        {
            return PartialView();
        }
        public PartialViewResult PartialTeam()
        {
            return PartialView();
        }
        public PartialViewResult Contact2()
        {
            var values = travelContext.Contacts.ToList();
            return PartialView(values);
        }
        public PartialViewResult Map()
        {
            return PartialView();

        }
    }
}