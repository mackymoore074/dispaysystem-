using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryModels.Models
{
    public class MenuItems
    {
        public int Id { get; set; }
        public string MenuDescription { get; set; } // Name of the menu item
        public List<Location> Locations { get; set; }
        public DateTime DateCreated { get; set; } // When the content was created
        public DateTime TimeOutDate { get; set; } // When the content should be removed from display


    }
}
