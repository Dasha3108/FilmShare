using FilmShare.Models.Storage;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmShare.Components.Profile
{
    public class ReviewsViewComponent : ViewComponent
    {
        private readonly IStorage _storage;

        public ReviewsViewComponent(IStorage storage)
        {
            _storage = storage;
        }

        public IViewComponentResult Invoke(int userId)
        {
            var reviews = _storage.GetUserReviews(userId);
            return View(reviews);
        }
    }
}
