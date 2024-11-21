using ClassLibraryModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryModels.Models
{
    public class Agency
    {
        public int Id { get; set; }
        public string Name { get; set; } // Agency name (e.g., "David & Margaret")
        public string Description { get; set; } // Description of the Agency
        public DateTime DateCreated { get; set; }
        public List<Department> Departments { get; set; } // Departments under this Agency
        public List<Location> Locations { get; set; } // Locations under this Agency

    }
}
