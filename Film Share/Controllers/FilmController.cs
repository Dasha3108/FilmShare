using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilmShare.Models.Storage;
using Microsoft.AspNetCore.Authorization;
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

        [Route("film/{filmId:dynamicFilm}")]
        public IActionResult Index(int filmId)
        {
            if (filmId == 0) RedirectToAction("Films", "Search");

            var film = _storage.GetFilmById(filmId);

            if (film == null) return NotFound();
            return View(film);
        }
        
        [Authorize]
        public IActionResult AddReview(string filmId, string rating, string text)
        {
            var responce = _storage.AddReview(User.Identity.Name, int.Parse(filmId), int.Parse(rating), text);

            return Json(responce);
        }

        public IActionResult ReviewsComponent(int filmId)
        {
            return ViewComponent("FilmShare.Components.Film.Reviews", filmId);
        }

        [Route("film/actors/{filmId:dynamicFilm}")]
        public IActionResult FilmActors(int filmId)
        {
            var filmRoles = _storage.GetFilmRoles(filmId);
            var film = _storage.GetFilmById(filmId);

            if (film == null) return NotFound();
            return View((filmRoles, film.FilmName));
        }
    }
}