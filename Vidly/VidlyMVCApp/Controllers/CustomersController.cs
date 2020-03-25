using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyMVCApp.Models;
using VidlyMVCApp.ViewModel;

namespace VidlyMVCApp.Controllers
{
    public class CustomersController : Controller
    {
        //ApplicationDbContext _context;
        //public CustomersController()
        //{
        //    //_context = new ApplicationDbContext();
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    //_context.Dispose();
        //}

        // GET: Customers
        public ActionResult Index()
        {
            var customers = GetViewModel();
            // _context.Customers.Include(c => c.MembershipType).ToList();
            
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customers = GetCustomers().SingleOrDefault(c => c.Id == id);

            if(customers == null)
            {
                return HttpNotFound();
            }
            return View("CustomerDetail", customers);
        }

        public ActionResult New()
        {
            return View();
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>()
            {
                new Customer{ Id = 1, Name = "Alok Singh"},
                new Customer{ Id = 2, Name = "Anjali Singh"}
            };
        }

        private RandomMovieViewModel GetViewModel()
        {
            var customer = new List<Customer>()
            {
                new Customer{ Id = 1, Name = "Alok Singh"},
                new Customer{ Id = 2, Name = "Anjali Singh"}
            };

            var movie = new Movie() { Name = "Bajirao Mastani"};

            var viewModel = new RandomMovieViewModel()
            {
                Customers = customer,
                Movie = movie
            };

            return viewModel;
        }
    }
}