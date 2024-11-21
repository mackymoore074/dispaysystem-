using ClassLibraryModels.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibraryModels.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } // Department name (e.g., "Mental Health", "Bliss")

        public string Description { get; set; } // Description of the department
        public DateTime DateCreated { get; set; }
        public List<Admin> Admins { get; set; } = new List<Admin>(); // Admins linked to this department
        public List<Screen> Screens { get; set; } = new List<Screen>(); // Screens in the department
    }

}
