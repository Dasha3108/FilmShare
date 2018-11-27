using FilmShare.Models.Storage;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FilmShare.ViewComponents.Admin
{
    public class FilmsViewComponent : ViewComponent
    {
        private readonly IStorage _storage;

        public FilmsViewComponent(IStorage storage)
        {
            _storage = storage;
        }

        public IViewComponentResult Invoke()
        {
            var films = _storage.GetAllFilms();
            return View(films);
        }
    }
}
