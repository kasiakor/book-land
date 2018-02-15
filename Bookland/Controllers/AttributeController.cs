using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bookland.Controllers
{
    public class AttributeController : Controller
    {
        // GET: Attribute

       // used when we want the action name to be different than the method name
       //[ActionName("Default")]
        public ActionResult Index()
        {
            return View();
        }
        //this method will execute only if the request method in HttpPost
        [HttpPost]
        public ActionResult Index(string personName)
        {
            return View();
        }
    }
}