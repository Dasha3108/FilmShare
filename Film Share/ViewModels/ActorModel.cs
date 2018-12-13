using FilmShare.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmShare.ViewModels
{
    public class ActorModel
    {
        public int ActorId { get; set; }

        [Required(ErrorMessage = "The name is required")]
        public string Name { get; set; }
        public string PhotoPath { get; set; }

        [Required(ErrorMessage = "The date of birth is required")]
        public DateTime DateOfBirth { get; set; }
        public bool IsInCurrentFilm { get; set; } = false;

        public ActorModel() { }

        public ActorModel(Actor actor)
        {
            ActorId = actor.ActorId;
            Name = actor.ActorName;
            PhotoPath = GetPhotoFromByteArray(actor.Photo);
            DateOfBirth = actor.DateOfBirth;
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
