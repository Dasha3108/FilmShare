using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilmShare.Models.Storage;
using FilmShare.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FilmShare.Controllers
{
    public class AdminController : Controller
    {
        private readonly IStorage _storage;

        public AdminController(IStorage storage)
        {
            _storage = storage;
        }

        [Authorize]
        public IActionResult Index(TabViewModel tab)
        {
            if (!_storage.IsUserAdmin(User.Identity.Name))
                return RedirectToAction("Index", "Home");
            
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

        public IActionResult GetAllActors()
        {
            var actors = _storage.GetAllActorModels();
            return Json(actors);
        }
    }
}