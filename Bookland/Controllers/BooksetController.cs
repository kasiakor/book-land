using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bookland.Controllers
{
    public class BooksetController : Controller
    {
        // GET: Bookset
        public ActionResult NewBook()
        {
            return View();
        }
    }
}