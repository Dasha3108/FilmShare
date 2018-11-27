using FilmShare.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmShare.ViewModels
{
    public class FilmModel
    {
        public int FilmId { get; }
        public string FilmName { get; set; }
        public string PosterPath { get; set; }
        public ushort Year { get; set; }
        public string Country { get; set; }

        public FilmModel() { }

        public FilmModel(Film film)
        {
            FilmId = film.FilmId; 
            FilmName = film.FilmName;
            Year = film.Year;
            PosterPath = GetPhotoFromByteArray(film.Poster);
            Country = film.Country;
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
