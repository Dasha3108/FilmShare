﻿using FilmShare.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace FilmShare.ViewModels
{
    public class ProfileModel
    {
        public int ProfileId { get; }
        public string Email { get; set; }

        [Required(ErrorMessage = "The name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The date of birth is required")]
        public DateTime DateOfBirth { get; set; }
        public string PhotoPath { get; set; }
        public int UserId { get; set; }

        public ProfileModel() { }

        public ProfileModel(Profile profile)
        {
            ProfileId = profile.ProfileId;
            Name = profile.Name;
            DateOfBirth = profile.DateOfBirth;
            PhotoPath = GetPhotoFromByteArray(profile.Photo);
            UserId = profile.UserId;
        }

        public ProfileModel(Profile profile, string email)
        {
            ProfileId = profile.ProfileId;
            Name = profile.Name;
            DateOfBirth = profile.DateOfBirth;
            PhotoPath = GetPhotoFromByteArray(profile.Photo);
            Email = email;
            UserId = profile.UserId;
        }

        private string GetPhotoFromByteArray(byte[] photoArray)
        {
            if (photoArray == null)
                return "/images/user-profile.jpg";

            var imageBase64Data = Convert.ToBase64String(photoArray);
            var photoPath = string.Format("data:image/png;base64,{0}", imageBase64Data);

            return photoPath;
        }
    }
}
