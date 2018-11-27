using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmShare.Models.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool IsBlocked { get; set; } = false;

        public virtual Profile Profile { get; set; }
        public virtual ICollection<Rank> Ranks { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }

        public virtual ICollection<UserPermission> UserPermissions { get; set; }
        public virtual ICollection<UserRelationships> MainUserRelationships { get; set; }
        public virtual ICollection<UserRelationships> DependentUserRelationships { get; set; }

        public IEnumerable<UserRelationships> UserRelationships {
            get
            {
                if (MainUserRelationships != null && DependentUserRelationships != null)
                    return MainUserRelationships.Concat(DependentUserRelationships).Distinct();

                if (MainUserRelationships != null) return MainUserRelationships;
                if (DependentUserRelationships != null) return DependentUserRelationships;

                return null;
            }
        }
    }
}
