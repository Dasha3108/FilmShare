using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilmShare.Models.Storage;
using Microsoft.AspNetCore.Mvc;

namespace FilmShare.Controllers
{
    public class ActorController : Controller
    {
        private readonly IStorage _storage;

        public ActorController(IStorage storage)
        {
            _storage = storage;
        }

        [Route("actor/{actorId:dynamicActor}")]
        public IActionResult Index(int actorId)
        {
            var actor = _storage.GetActorById(actorId);

            if (actor == null) return NotFound();
            return View(actor);
        }
    }
}