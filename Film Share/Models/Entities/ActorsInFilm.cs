using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmShare.Models.Entities
{
    public class ActorsInFilm
    {
        public int ActorId { get; set; }
        public virtual Actor Actor { get; set; }

        public int FilmId { get; set; }
        public virtual Film Film { get; set; }

        public string Role { get; set; } 
    }
}
