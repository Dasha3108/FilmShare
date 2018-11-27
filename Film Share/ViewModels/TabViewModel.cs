using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmShare.ViewModels
{
    public class TabViewModel
    {
        public Tab ActiveTab { get; set; } 
    }

    public enum Tab
    {
        Friends,
        Films, 
        Actors,
        Users
    }
}
