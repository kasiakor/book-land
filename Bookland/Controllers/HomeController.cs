using Bookland.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bookland.Controllers
{
    public class HomeController : Controller

    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            int BlockSize = 5;
            var books = DataManager.GetBooks(1, BlockSize);
            return View(books);
        }

        [ChildActionOnly]
        public ActionResult BookList(List<Bookset> Model)
        {
            return PartialView(Model);
        }

        [HttpPost]
        public ActionResult InfinateScroll(int BlockNumber)
        {

            int BlockSize = 5;
            var books = DataManager.GetBooks(BlockNumber, BlockSize);

            JsonModel jsonModel = new JsonModel();
            jsonModel.NoMoreData = books.Count < BlockSize;
            jsonModel.HTMLString = RenderPartialViewToString("BookList", books);

            return Json(jsonModel);
        }

        protected string RenderPartialViewToString(string viewName, object model)
        {
            if (string.IsNullOrEmpty(viewName))
                viewName = ControllerContext.RouteData.GetRequiredString("action");

            ViewData.Model = model;

            using (StringWriter sw = new StringWriter())
            {
                ViewEngineResult viewResult = ViewEngines.Engines.FindPartialView(ControllerContext, viewName);
                ViewContext viewContext = new ViewContext(ControllerContext, viewResult.View, ViewData, TempData, sw);
                viewResult.View.Render(viewContext, sw);

                return sw.GetStringBuilder().ToString();
            }
        }
    }
}
    //{
    //    // used when we want the action name to be different than the method name
    //    //[ActionName("Default")]
    //    [HttpPost]
    //    public ActionResult Index()
    //    {
    //        return View();
    //    }
    //    //this method will execute only if the request method in HttpPost
    //    [HttpPost]
    //    public ActionResult Index(string personName)
    //    {
    //        return View();
    //    }
    //    //public ActionResult Index()

    //{
    //    ViewBag.CurrentDateAndTime = DateTime.Now;
    //    return View();
    //}

    //public ActionResult GoToHome ()
    //{
    //    return View();
    //}

    //public ActionResult About(int? id)
    //{
    //    //if (id.HasValue)
    //    //    ViewData["id"] = id.Value;
    //    //else
    //    //    ViewData["id"] = 0;

    //    if (id.HasValue)
    //        ViewBag.Id = id.Value;
    //    else
    //        ViewBag.Id = 0;
    //    return View();
    //}

    //public ActionResult Contact()
    //{
    //    ViewBag.Message = "Your contact page.";

    //    return View();
    //}
