using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using FilmShare.Models.Storage;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;

namespace FilmShare.Hubs
{
    [Authorize]
    public class ReviewsHub : Hub
    {
        private readonly IStorage _storage;
        private readonly IHttpContextAccessor _contextAccessor;

        public ReviewsHub(IStorage storage, IHttpContextAccessor contextAccessor)
        {
            _storage = storage;
            _contextAccessor = contextAccessor;
        }

        public async Task AddReview(string filmId, string rating, string text)
        {
            var currentUser = _contextAccessor.HttpContext.User.Identity.Name;
            var responce = _storage.AddReview(currentUser, int.Parse(filmId), int.Parse(rating), text);
            await Clients.All.SendAsync("ReceiveReview", responce);
        }
    }
}
