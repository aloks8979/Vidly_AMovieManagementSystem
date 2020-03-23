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
    }
}