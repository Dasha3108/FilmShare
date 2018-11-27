using FilmShare.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmShare.ViewModels
{
    public class FilmReviewViewModel
    {
        public float Rating { get; }
        public string Text { get; }
        public int ProfileId { get; }
        public string UserPhotoPath { get; }
        public string UserName { get; }
        public DateTime ReviewDate { get; }

        public FilmReviewViewModel() { }

        public FilmReviewViewModel(Review review, ProfileModel profile)
        {
            ProfileId = profile.ProfileId;
            Rating = review.Rating;
            Text = review.Text;
            UserName = profile.Name;
            UserPhotoPath = profile.PhotoPath;
            ReviewDate = review.ReviewDate;
        }
    }
}
