using FilmShare.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmShare.ViewModels
{
    public class FilmModel
    {
        public int FilmId { get; set; }

        [Required(ErrorMessage = "The name is required")]
        public string FilmName { get; set; }
        public string PosterPath { get; set; }

        [Required(ErrorMessage = "The year is required")]
        [Range(1900, 2030)]
        public ushort Year { get; set; }
        [Required(ErrorMessage = "The country is required")]
        public string Country { get; set; }
        public float AverageRank { get; set; }

        public FilmModel() { }

        public FilmModel(Film film)
        {
            FilmId = film.FilmId; 
            FilmName = film.FilmName;
            Year = film.Year;
            PosterPath = GetPhotoFromByteArray(film.Poster);
            Country = film.Country;
            AverageRank = film.AverageRank;
        }

        private string GetPhotoFromByteArray(byte[] photoArray)
        {
            if (photoArray == null)
                return "/images/no-poster.jpg";

            var imageBase64Data = Convert.ToBase64String(photoArray);
            var photoPath = string.Format("data:image/png;base64,{0}", imageBase64Data);

            return photoPath;
        }
    }
}
