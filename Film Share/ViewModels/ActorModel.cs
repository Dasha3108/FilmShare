using FilmShare.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmShare.ViewModels
{
    public class ActorModel
    {
        public string Name { get; set; }
        public string PhotoPath { get; set; }
        public DateTime DateOfBirth { get; set; }

        public ActorModel() { }

        public ActorModel(Actor actor)
        {
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
