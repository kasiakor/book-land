using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bookland.Models;
using Bookland.ViewModels;

namespace Bookland.Controllers
{
    public class BooksController : Controller
    {
        // GET: Books/Random
        public ActionResult Random()
        {
            var book = new Book() { Name = "Eleni", Id = 1 };
            var authors = new List<Author>
            {
                new Author { Name = "Author 1"},
                new Author { Name = "Author 2"}
            };

            var viewModel = new RandomBookViewModel
            {
                Book = book,
                Authors = authors
            };

            return View(viewModel);
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

        // applay route attribute and pass the url template

        [Route("books/released/{year}/{month:regex(\\d{2})}:range(1,12)")]

        public ActionResult ByReadDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}