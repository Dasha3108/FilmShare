﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using FilmShare.Models.DataAccessLayer;
using FilmShare.Models.Storage;
using FilmShare.ViewModels.Account;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;

namespace FilmShare.Controllers
{
    public class AccountController : Controller
    {
        private readonly IStorage _storage;
        private readonly IStringLocalizer<AccountController> _localizer;

        public AccountController(IStorage storage, IStringLocalizer<AccountController> localizer)
        {
            _storage = storage;
            _localizer = localizer;
        }
        
        public IActionResult Login()
        {
            return View("LogIn");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LogInModel model)
        {
            if (ModelState.IsValid)
            {
                if (_storage.IsUserAutenticationInfoCorrect(model.Login, model.Password))
                {
                    await Authenticate(model.Login);

                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", _localizer["Incorrect login or password"]);
            }

            return View("LogIn");
        }
        
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                if (!_storage.UserExists(model.Login, model.Email))
                {
                    _storage.AddUser(model);

                    await Authenticate(model.Login); 

                    return RedirectToAction("Login", "Account");
                }
                else
                    ModelState.AddModelError("", _localizer["The user with such login or email already exists"]);
            }

            return View(model);
        }

        private async Task Authenticate(string login)
        {
            var claims = new List<Claim> { new Claim(ClaimsIdentity.DefaultNameClaimType, login) };
            
            var id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }
    }
}