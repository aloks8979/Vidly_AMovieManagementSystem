using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyMVCApp.Models;

namespace VidlyMVCApp.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movies = new Movie()
            {
                Name = "Shrek!"
            };

            return View(movies);
        }

        //ByReleaseYear
        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        public ActionResult ByReleaseYear(int year, int month)
        {

            return Content(year + "/" + month);
        }

        //ViewData and ViewBag example and than View Model
    }
}