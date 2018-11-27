using FilmShare.Models.Storage;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FilmShare.ViewComponents.Search
{
    public class ActorsViewComponent : ViewComponent
    {
        private readonly IStorage _storage;

        public ActorsViewComponent(IStorage storage)
        {
            _storage = storage;
        }

        public IViewComponentResult Invoke()
        {
            var actors = _storage.GetAllActors();
            return View(actors);
        }
    }
}
