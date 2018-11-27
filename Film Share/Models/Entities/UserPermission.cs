using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmShare.Models.Entities
{
    public class UserPermission
    {
        public int UserId { get; set; }
        public virtual User User { get; set; }

        public int PermissionId { get; set; }
        public virtual Permission Permission { get; set; }
    }
}
