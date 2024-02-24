using Microsoft.AspNetCore.Mvc;
using Mission6_VivianSolgere_413.Models;
using System.Diagnostics;

namespace Mission6_VivianSolgere_413.Controllers
{
    public class HomeController : Controller
    {
        private readonly MovieCollectionContext _movieCollectionContext;

        // Constructor with only the MovieCollectionContext dependency
        public HomeController(MovieCollectionContext movieCollectionContext)
        {
            _movieCollectionContext = movieCollectionContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult MovieCollection()
        {
            return View(new Movie());
        }

        [HttpPost]
        public IActionResult AddMovie(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _movieCollectionContext.Movies.Add(movie);
                _movieCollectionContext.SaveChanges();

                return RedirectToAction("ConfirmationPage");
            }

            return View("MovieCollection", movie);
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
    }
}

