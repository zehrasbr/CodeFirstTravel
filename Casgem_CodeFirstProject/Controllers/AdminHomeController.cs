using Casgem_CodeFirstProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    public class AdminHomeController : Controller
    {
        TravelContext travelContext = new TravelContext();

        public ActionResult Index()
        {
            var values = travelContext.Bookings.ToList();
            return View(values);
        }
    }
}