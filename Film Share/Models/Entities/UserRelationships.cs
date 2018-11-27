using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmShare.Models.Entities
{
    public class UserRelationships
    {
        public int MainUserId { get; set; }
        public virtual User MainUser { get; set; }

        public int DependentUserId { get; set; }
        public virtual User DependentUser { get; set; }

        public int RelationshipId { get; set; }
        public virtual Relationship Relationship { get; set; }
    }
}
