﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilmShare.Models.Storage;
using FilmShare.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FilmShare.Controllers
{
    [Route("api/Friendship")]
    [ApiController]
    [Authorize]
    public class FriendshipController : ControllerBase
    {
        private readonly IStorage _storage;

        public FriendshipController(IStorage storage)
        {
            _storage = storage;
        }

        [HttpGet]
        public ActionResult<List<ProfileModel>> GetFriends()
        {
            var profiles = _storage.GetUserFriendsProfiles(User.Identity.Name);

            if (profiles == null)
                return NotFound();

            return profiles;
        }

        [HttpPut("{friendUserId}")]
        public IActionResult AddFriend(int friendUserId)
        {
            if (_storage.AddFriend(User.Identity.Name, friendUserId))
            {
                return NoContent();
            }
            return NotFound();
        }

        [HttpDelete("{friendUserId}")]
        public IActionResult RemoveFriend(int friendUserId)
        {
            if (_storage.RemoveFriend(User.Identity.Name, friendUserId))
            {
                return NoContent();
            }
            return NotFound();
        }

    }

}