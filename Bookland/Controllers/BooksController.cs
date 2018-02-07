using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bookland.Models;

namespace Bookland.Controllers
{
    public class BooksController : Controller
    {
        // GET: Books/Random
        public ActionResult Random()
        {
            var book = new Book() { Name = "Eleni" };

            return View(book);
            // return Content("Hello World!");
            // return HttpNotFound();
            // return new EmptyResult();
            // return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }

        //public  ActionResult Edit(int id)
        //{
        //    return Content("id=" + id);
        //}

        ////movies 
        //public ActionResult Index(int? pageIndex, string sortBy)
        //{

        //    //check if parameters have a value
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;

        //    if (String.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";

        //    return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        //}

        public ActionResult ByReadDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}