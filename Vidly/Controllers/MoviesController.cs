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
        //[Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1, 12)}")]
        [Route("movies/released/{year}/{month}")]

        public ActionResult ByReleaseYear(int year, int month)
        {
            if (year < 1900)
                return Content(year + " is not in a 4 digit format.");
            if (month > 12 || month < 01)
                return Content(month + "is not in a 2 digit format.");
            return Content(year + "/" + month);
        }


        // GET: Movies
        public ActionResult Index()
        {
            var shrek = new Movie() { Id = 1, Name = "Shrek" };
            return View(shrek);
        }

        

        //public actionresult byreleasedate(int year, int month)
        //{
        //    return content(year + "/" + month);
        //}

    }

}