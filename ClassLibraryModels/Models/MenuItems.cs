using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassLibraryModels.Models
{
    public class MenuItems
    {
        public MenuItems()
        {
            Locations = new List<Location>();
        }

        [Required]
        public int Id { get; set; }
        [Required]
        public string MenuDescription { get; set; } // Name of the menu item
        public ICollection<Location> Locations { get; set; }
        public DateTime DateCreated { get; set; } // When the content was created
        public DateTime TimeOutDate { get; set; } // When the content should be removed from display
        public DateTime LastUpdated { get; set; }


    }
}
