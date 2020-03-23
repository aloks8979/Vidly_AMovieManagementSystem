using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyMVCApp.Models;
using VidlyMVCApp.ViewModel;

namespace VidlyMVCApp.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var movies = new Movie()
            {
                Name = "Bajirao Mastani"
            };

            var customers = new List<Customer>()
            {
                new Customer{ Name = "Alok Singh" },
                new Customer{ Name = "Anjali Singh" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movies,
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Details()
        {

            return View("CustomerDetail");
        }
    }
}