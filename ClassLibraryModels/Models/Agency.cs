using ClassLibraryModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassLibraryModels.Models
{
    public class Agency
    {
        public Agency()
        {
            Departments = new List<Department>();
            Locations = new List<Location>();
        }

        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Description { get; set; }
        
        public ICollection<Department> Departments { get; set; }
        public ICollection<Location> Locations { get; set; }
    }
}
