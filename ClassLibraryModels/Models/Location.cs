using ClassLibraryModels.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryModels.Models

{
    public class Location
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; } // Location name (e.g., "Foothill (Finance)")

        [Required]
        [StringLength(500)]
        public string Address { get; set; } // Physical address of the location

        public DateTime DateCreated { get; set; }

        public List<Screen> Screens { get; set; } = new List<Screen>(); // Screens in this location
        public List<Department> Departments { get; set; } = new List<Department>(); // Departments in this location
        public List<string> AllowedIpAddresses { get; set; } // Public IPs allowed to retrieve news

        // Constructor
        public Location()
        {
            AllowedIpAddresses = new List<string>();
        }
    }
}

