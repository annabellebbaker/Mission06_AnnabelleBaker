using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission06_AnnabelleBaker.Models;

namespace Mission06_AnnabelleBaker.Controllers
{
    public class HomeController : Controller
    {

        private MoviesContext _context; // adding context file

        public HomeController(MoviesContext temp) // constructor - receive an instance and assign it to a variable
        {
            _context = temp; // import information based on context, add
        }
        public IActionResult Index() // home page
        {
            return View();
        }
        
        public IActionResult GetToKnowJoel() // get to know Joel page
        {
            return View("GetToKnowJoel");
        }

        [HttpGet]
        public IActionResult EnterMovies() // enter movies page (Joel's Film Collection)
        {
            return View("EnterMovies");
        }

        [HttpPost]
        public IActionResult EnterMovies(Movies item) // enter in the parameter of the datatype
        {
            _context.Movies.Add(item); // making sure it adds items to database
            _context.SaveChanges(); // saving changes to the database
            
            return View("Confirmation", item);
        }


    }
}
