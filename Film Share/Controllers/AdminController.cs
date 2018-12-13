using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilmShare.Attributes;
using FilmShare.Models.Storage;
using FilmShare.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FilmShare.Controllers
{
    [Authorize]
    [ServiceFilter(typeof(CheckAdminFilter))]
    public class AdminController : Controller
    {
        private readonly IStorage _storage;
        
        public AdminController(IStorage storage, IHttpContextAccessor contextAccessor)
        {
            _storage = storage;
        }
        
        public IActionResult Index(TabViewModel tab)
        {            
            if (tab == null || tab.ActiveTab == Tab.Friends)
            {
                tab = new TabViewModel
                {
                    ActiveTab = Tab.Users
                };
            }

            return View(tab);
        }

        public IActionResult SwitchTabs(string tabname)
        {
            var tab = new TabViewModel();

            switch (tabname)
            {
                case "Users":
                    tab.ActiveTab = Tab.Users;
                    break;
                case "Actors":
                    tab.ActiveTab = Tab.Actors;
                    break;
                case "Films":
                    tab.ActiveTab = Tab.Films;
                    break;
            }

            return RedirectToAction("Index", tab);
        }

        public IActionResult CreateFilm()
        {
            return View();
        }

        public IActionResult EditFilm(int filmId)
        {
            var film = _storage.GetFilmById(filmId);

            if (film == null) return NotFound();
            return View(film);
        }

        [HttpPost]
        public IActionResult EditFilm(FilmModel filmModel, IFormFile poster)
        {
            _storage.UpdateFilm(filmModel, poster);

            var tab = new TabViewModel() { ActiveTab = Tab.Films };
            return RedirectToAction("Index", tab);
        }

        [HttpPost]
        public IActionResult CreateFilm(FilmModel filmModel, IFormFile poster)
        {
            _storage.CreateFilm(filmModel, poster);

            var tab = new TabViewModel() { ActiveTab = Tab.Films };
            return RedirectToAction("Index", tab);
        }

        public IActionResult CreateActor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateActor(ActorModel actorModel, IFormFile poster)
        {
            _storage.CreateActor(actorModel, poster);

            var tab = new TabViewModel() { ActiveTab = Tab.Actors };
            return RedirectToAction("Index", tab);
        }

        public IActionResult EditActor(int actorId)
        {
            var actor = _storage.GetActorById(actorId);

            if (actor == null) return NotFound();
            return View(actor);
        }

        [HttpPost]
        public IActionResult EditActor(ActorModel actorModel, IFormFile poster)
        {
            _storage.UpdateActor(actorModel, poster);

            var tab = new TabViewModel() { ActiveTab = Tab.Actors };
            return RedirectToAction("Index", tab);
        }

        public IActionResult GetAllActors(int filmId)
        {
            var actors = _storage.GetNotInFilmActorsModels(filmId);
            return Json(actors);
        }

        public IActionResult ManageFilmActors(int filmId)
        {
            var roles = _storage.GetFilmRoles(filmId);

            if (roles == null) return NotFound();
            return View((roles, filmId));
        }
        
        public IActionResult AddActorToFilm(int actorId, int filmId, string title)
        {
            var (success, role) = _storage.AddActorToFilm(actorId, filmId, title);
            return Json(new { success, role });
        }

        public IActionResult ChangeActorRole(int actorId, int filmId, string title)
        {
            var (success, role) = _storage.ChangeActorRole(actorId, filmId, title);
            return Json(new { success, role });
        }

        public IActionResult RemoveActorFromFilm(int actorId, int filmId)
        {
            var responce = _storage.RemoveActorFromFilm(actorId, filmId);
            return Json(responce);
        }

        public IActionResult DeleteFilm(int filmId)
        {
            var success = _storage.DeleteFilm(filmId);
            return Json(success);
        }

        public IActionResult DeleteActor(int actorId)
        {
            var success = _storage.DeleteActor(actorId);
            return Json(success);
        }

        public IActionResult AddAdminPermission(int userId, int permissionId)
        {
            var responce = _storage.GiveAdminPermission(userId, permissionId);
            return Json(responce);
        }

        public IActionResult RemoveAdminPermission(int userId, int permissionId)
        {
            var responce = _storage.RemoveAdminPermission(userId, permissionId);
            return Json(responce);
        }

        public IActionResult ActorsComponent(string filter)
        {
            return ViewComponent("FilmShare.ViewComponents.Admin.Actors", filter);
        }

        public IActionResult FilmsComponent(string filter)
        {
            return ViewComponent("FilmShare.ViewComponents.Admin.Films", filter);
        }

        public IActionResult UsersComponent(string filter)
        {
            return ViewComponent("FilmShare.ViewComponents.Admin.Users", filter);
        }
    }
}