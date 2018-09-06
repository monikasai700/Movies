using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };
            return View(movie);
            //return RedirectToAction("Index","Home");
        }
        public ActionResult Edit(int id)
        {
            return Content("id=" +id);
        }
        public ActionResult Index(int? pageindex , string sortby)
        {
            if (!pageindex.HasValue)
                pageindex = 1;
            if (String.IsNullOrWhiteSpace(sortby))
                sortby = "Name";
            return Content(string.Format("pageindex={0}&sortby={1}",pageindex,sortby));
        }
    }
}