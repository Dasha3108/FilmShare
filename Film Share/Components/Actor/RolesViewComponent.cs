using FilmShare.Models.Storage;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FilmShare.ViewComponents.Actor
{
    public class RolesViewComponent : ViewComponent
    {
        private readonly IStorage _storage;

        public RolesViewComponent(IStorage storage)
        {
            _storage = storage;
        }

        public IViewComponentResult Invoke(int actorId)
        {
            var roles = _storage.GetActorRoles(actorId);
            return View(roles);
        }
    }
}
