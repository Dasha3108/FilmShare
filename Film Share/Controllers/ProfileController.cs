using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilmShare.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using FilmShare.Models.Storage;
using Microsoft.AspNetCore.Http;

namespace FilmShare.Controllers
{
    public class ProfileController : Controller
    {
        private readonly IStorage _storage;

        public ProfileController(IStorage storage)
        {
            _storage = storage;
        }

        [Route("")]
        [Route("{profileId:dynamicProfile}")]
        public IActionResult Index(int profileId)
        {
            var isAuthenticated = User.Identity.Name != null;
            if (!isAuthenticated && profileId == 0) return RedirectToAction("Login", "Account");
            
            ProfileModel profileModel;
            if (profileId == 0)
            {
                var userName = User.Identity.Name;
                profileModel = _storage.GetProfileModelByEmailOrLogin(userName);
                ViewBag.isCurrentUser = true;
            }
            else
            {
                profileModel = _storage.GetProfileModelById(profileId);

                var currentUserProfile = _storage.GetProfileModel(User.Identity.Name);

                if (!isAuthenticated || profileModel == null)
                    ViewBag.isCurrentUser = false;
                else
                    ViewBag.isCurrentUser = profileModel.ProfileId == currentUserProfile.ProfileId ? true : false;
            }

            if (profileModel != null)
            {
                ViewBag.areFriends = _storage.CheckIfUsersAreFriends(User.Identity.Name, profileModel.UserId);

                return View(profileModel);
            }

            return NotFound();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> UpdatePhoto(IFormFile photo)
        {
            var userName = User.Identity.Name;
            var profileModel = await _storage.UpdateProfilePhoto(userName, photo);

            ViewBag.isCurrentUser = true;

            return View("Index", profileModel);
        }

        [Authorize]
        [Route("edit")]
        public IActionResult Edit()
        {
            var profile = _storage.GetProfileModel(User.Identity.Name);
            
            return View(profile);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Edit(ProfileModel profileModel)
        {
            _storage.UpdateProfile(User.Identity.Name, profileModel);

            return RedirectToAction("Index");
        }

        [Authorize]
        [Route("friends")]
        public IActionResult Friends()
        {
            var friends = _storage.GetUserFriendsProfiles(User.Identity.Name);

            return View("Friends", friends);
        }

        [Authorize]
        [Route("reviews")]
        public IActionResult Reviews()
        {
            var userId = _storage.GetUserId(User.Identity.Name);

            return View(userId);
        }
    }
}