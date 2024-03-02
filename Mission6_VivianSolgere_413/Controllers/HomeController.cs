using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Mission6_VivianSolgere_413.Models;
using System.Diagnostics;

namespace Mission6_VivianSolgere_413.Controllers
{
    public class HomeController : Controller
    {
        private MovieCollectionContext _context;

        // Constructor with only the MovieCollectionContext dependency
        public HomeController(MovieCollectionContext movieCollectionContext)
        {
            _context = movieCollectionContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieCollection()
        {

            ViewBag.Categories = _context.Categories.ToList();
            return View(new Movie());
        }

        [HttpPost]
        public IActionResult AddMovie(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(movie);
                _context.SaveChanges();

                return View("ConfirmationPage", movie);

            }
            else
            {
                ViewBag.Categories = _context.Categories.ToList();
                return View("MovieCollection", movie);
            }
            
        }

        public IActionResult ConfirmationPage()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult MovieEntries()
        {
            //linq
            var movies = _context.Movies
                .Include(x => x.Category)
                .OrderBy(x => x.Title)
                .ToList();
            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Movie recordToEdit = _context.Movies
                .Single(x => x.MovieId == id);

            ViewBag.Categories = _context.Categories.ToList();

            return View(recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Movie updatedInfo) {

            _context.Movies.Update(updatedInfo);
            _context.SaveChanges();

            return RedirectToAction("MovieEntries");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Movies.Single(m => m.MovieId == id);
            if (recordToDelete != null)
            {
                _context.Movies.Remove(recordToDelete);
                _context.SaveChanges();
            }
            return RedirectToAction("MovieEntries");
        }
    }
}

