using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmShare.Models.Entities
{
    public class Rank
    {
        public int RankId { get; set; }
        public float Rating { get; set; }
        public int UserId { get; set; }
        public int FilmId { get; set; }

        public virtual User User { get; set; }
        public virtual Film Film { get; set; }
    }
}
