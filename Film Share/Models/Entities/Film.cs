using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmShare.Models.Entities
{
    public class Film
    {
        public int FilmId { get; set; }
        public string FilmName { get; set; }
        public byte[] Poster { get; set; }
        public ushort Year { get; set; }
        public string Country { get; set; }
        public float AverageRank { get; set; }

        public virtual ICollection<ActorsInFilm> ActorsInFilms { get; set; }
        public virtual ICollection<Rank> Ranks { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
