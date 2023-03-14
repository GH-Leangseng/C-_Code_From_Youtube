using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web_MVC_basic.Models;

namespace web_MVC_basic.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie(){ Name = "Seng" };
            //return new ViewResult();
            //return Content("Hello wrold");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
            return View(movie);

        }
        public ActionResult Edit(int movieId)
        {
            return Content("Hello ID : " + movieId);
        }
        public ActionResult Index(int? pageIndex , string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1; 
            }
            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }
            return Content(String.Format("pageIndex = {0} & sortBy={1}"));
        }
    }
}