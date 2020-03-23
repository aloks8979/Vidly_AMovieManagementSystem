using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyMVCApp.Models;

namespace VidlyMVCApp.ViewModel
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}