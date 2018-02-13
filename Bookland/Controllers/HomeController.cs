using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bookland.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()

        {
            ViewBag.CurrentDateAndTime = DateTime.Now;
            return View();
        }

        public ActionResult GoToHome ()
        {
            return View();
        }

        public ActionResult About(int? id)
        {
            //if (id.HasValue)
            //    ViewData["id"] = id.Value;
            //else
            //    ViewData["id"] = 0;

            if (id.HasValue)
                ViewBag.Id = id.Value;
            else
                ViewBag.Id = 0;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}