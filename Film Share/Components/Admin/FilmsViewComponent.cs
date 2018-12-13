using FilmShare.Models.Storage;
using FilmShare.ViewModels;
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

        public IViewComponentResult Invoke(string filter)
        {
            List<FilmModel> films;

            if (filter == null || filter == "")
                films = _storage.GetAllFilms();
            else
                films = _storage.GetAllFilmsWithFilter(filter);

            return View(films);
        }
    }
}
