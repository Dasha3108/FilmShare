using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FilmShare.Models;
using FilmShare.Models.Storage;
using Microsoft.AspNetCore.Authorization;

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
        
    }
}
