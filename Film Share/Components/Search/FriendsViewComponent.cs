using FilmShare.Models.Storage;
using FilmShare.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FilmShare.ViewComponents.Search
{
    public class FriendsViewComponent : ViewComponent
    {
        private readonly IStorage _storage;

        public FriendsViewComponent(IStorage storage)
        {
            _storage = storage;
        }

        public IViewComponentResult Invoke(string filter)
        {
            List<ProfileModel> users;

            var userName = User.Identity.Name;
            if (filter == null || filter == "")
            {
                if (userName != null)
                    users = _storage.GetAllProfileModelsWithoutFriends(User.Identity.Name);
                else
                    users = _storage.GetAllProfiles();
            }
            else
            {
                if (userName != null)
                    users = _storage.GetProfileModelsWithoutFriendsWithFilter(User.Identity.Name, filter);
                else
                    users = _storage.GetAllProfilesWithFilter(filter);
            }

            return View(users);
        }
    }
}
