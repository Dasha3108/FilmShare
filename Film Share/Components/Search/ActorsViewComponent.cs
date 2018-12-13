using FilmShare.Models.Storage;
using FilmShare.ViewModels;
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

        public IViewComponentResult Invoke(string filter)
        {
            List<ActorModel> actors;

            if (filter == null || filter == "")
                actors = _storage.GetAllActors();
            else
                actors = _storage.GetAllActorsWithFilter(filter);

            return View(actors);
        }
    }
}
