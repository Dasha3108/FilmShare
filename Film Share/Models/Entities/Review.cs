using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmShare.Models.Entities
{
    public class Review
    {
        public int ReviewId { get; set; }
        public int UserId { get; set; }
        public int FilmId { get; set; }
        public float Rating { get; set; }
        public string Text { get; set; }
        public DateTime ReviewDate { get; set; }

        public virtual User User { get; set; }
        public virtual Film Film { get; set; }
    }
}
