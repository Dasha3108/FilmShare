using FilmShare.Models.Storage;
using FilmShare.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FilmShare.ViewComponents.Admin
{
    public class UsersViewComponent : ViewComponent
    {
        private readonly IStorage _storage;

        public UsersViewComponent(IStorage storage)
        {
            _storage = storage;
        }

        public IViewComponentResult Invoke(string filter)
        {
            List<ProfileModel> users;

            if (filter == null || filter.StartsWith(""))
                users = _storage.GetAllProfiles(User.Identity.Name);

            else
            {
                users = _storage.GetAllProfilesWithFilter(User.Identity.Name, filter);
            }

            return View(users);
        }
    }
}
