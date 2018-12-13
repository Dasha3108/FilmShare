using System.Collections.Generic;
using FilmShare.Models.Storage;
using FilmShare.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FilmShare.Controllers
{
    public class SearchController : Controller
    {
        private readonly IStorage _storage;

        public SearchController(IStorage storage)
        {
            _storage = storage;
        }

        [Route("search")]
        public IActionResult Index(TabViewModel tab)
        {
            if (tab == null)
            {
                tab = new TabViewModel
                {
                    ActiveTab = Tab.Friends
                };
            }

            return View(tab);
        }

        public IActionResult SwitchTabs(string tabname)
        {
            var tab = new TabViewModel();

            switch (tabname) {
                case "Friends":
                    tab.ActiveTab = Tab.Friends;
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
        
        public JsonResult Friends()
        {
            var userName = User.Identity.Name;
            var users = new List<ProfileModel>();
            if (userName != null)
                users = _storage.GetAllProfileModelsWithoutFriends(User.Identity.Name);
            else
                users = _storage.GetAllProfiles();
            return Json(users);
        }

        public IActionResult ActorsComponent(string filter)
        {
            return ViewComponent("FilmShare.ViewComponents.Search.Actors", filter);
        }

        public IActionResult FilmsComponent(string filter)
        {
            return ViewComponent("FilmShare.ViewComponents.Search.Films", filter);
        }

        public IActionResult FriendsComponent(string filter)
        {
            return ViewComponent("FilmShare.ViewComponents.Search.Friends", filter);
        }
    }
}