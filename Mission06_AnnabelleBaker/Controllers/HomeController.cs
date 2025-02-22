using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission06_AnnabelleBaker.Models;
using static System.Net.Mime.MediaTypeNames;

namespace Mission06_AnnabelleBaker.Controllers
{
    public class HomeController : Controller
    {

        private MovieContext _context; // adding context file

        public HomeController(MovieContext temp) // constructor - receive an instance and assign it to a variable
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
            ViewBag.Category = _context.Categories.ToList();

            return View(new Movie());
        }

        [HttpPost]
        public IActionResult EnterMovies(Movie response)
        {
            if (ModelState.IsValid == false) // invalid input
            {
                ViewBag.Categories = _context.Categories.ToList();
                return View(response); 
            }
            else
            {
                _context.Movies.Add(response);
                _context.SaveChanges();
                return View("Confirmation", response);
            }
        }


        public IActionResult MovieList() // Movie List database page
        {
            // Linq
            var movies = _context.Movies
                .Include(m => m.Category)
                .ToList();

            return View(movies);
        }

        [HttpGet]
        // this is going to be a reference to the database and CRUD functionality
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == id); // going through route and can load up the correct record, grabs ONE single record

            ViewBag.Category = _context.Categories
                .OrderBy(x => x.CategoryName).ToList(); // store somewhere

            return View("EnterMovies", recordToEdit); // go back to dating application to edit
            // get action to form and access database info
        }

        [HttpPost]
        public IActionResult Edit(Movie updatedInfo) // returns ALL the information about the record
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Movies
                .Single(x => x.MovieId == id);

            return View(recordToDelete); // shows us the record to delete on the button

        }

        [HttpPost]
        public IActionResult Delete(Movie movie)
        {
            _context.Movies.Remove(movie); // not permanent in the actual database
            _context.SaveChanges();

            return RedirectToAction("MovieList");


        }
    }
}
