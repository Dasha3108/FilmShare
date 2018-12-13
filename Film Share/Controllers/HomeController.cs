using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FilmShare.Models;
using FilmShare.Models.Storage;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace FilmShare.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStorage _storage;

        public HomeController(IStorage storage)
        {
            _storage = storage;
        }

        [Authorize]
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Profile");
        }

        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

            return LocalRedirect(returnUrl);
        }

    }
}
