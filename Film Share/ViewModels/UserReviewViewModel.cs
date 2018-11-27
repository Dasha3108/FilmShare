using FilmShare.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmShare.ViewModels
{
    public class UserReviewViewModel
    {
        public float Rating { get; }
        public string Text { get; }
        public string FilmPosterPath { get; }
        public string FilmName { get; }
        public int FilmId { get; }
        public DateTime ReviewDate { get; }

        public UserReviewViewModel() { }

        public UserReviewViewModel(Review review, FilmModel film)
        {
            FilmId = film.FilmId;
            Rating = review.Rating;
            Text = review.Text;
            FilmName = film.FilmName;
            FilmPosterPath = film.PosterPath;
            ReviewDate = review.ReviewDate;
        }
    }
}
