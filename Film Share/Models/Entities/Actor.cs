using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmShare.Models.Entities
{
    public class Actor
    {
        public int ActorId { get; set; }
        public string ActorName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public byte[] Photo { get; set; }

        public virtual ICollection<ActorsInFilm> ActorsInFilms { get; set; }
    }
}
