using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmShare.ViewModels
{
    public class RoleModel
    {
        public FilmModel Film { get; set; }
        public ActorModel Actor { get; set; }
        public string Title { get; set; }

        public RoleModel(FilmModel film, ActorModel actor, string title)
        {
            Film = film;
            Actor = actor;
            Title = title;
        }
    }
}
