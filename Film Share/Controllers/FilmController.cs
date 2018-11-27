using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilmShare.Models.Storage;
using Microsoft.AspNetCore.Mvc;

namespace FilmShare.Controllers
{
    public class FilmController : Controller
    {
        private readonly IStorage _storage;

        public FilmController(IStorage storage)
        {
            _storage = storage;
        }

        public IActionResult Index(int filmId)
        {
            if (filmId == 0) RedirectToAction("Films", "Search");

            var film = _storage.GetFilmById(filmId);
            return View(film);
        }
        
        public IActionResult AddReview(string filmId, string rating, string text)
        {
            var success = _storage.AddReview(User.Identity.Name, int.Parse(filmId), int.Parse(rating), text);

            return Json(success);
        }

        public IActionResult ReviewsComponent(int filmId)
        {
            return ViewComponent("FilmShare.Components.Film.Reviews", filmId);
        }
    }
}