using ClassLibraryModels.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryModels.Models
{
    public class Screen
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } // Unique screen name (e.g., "DM001", "LH003")

        public int? LocationId { get; set; }
        [ForeignKey("LocationId")]
        public virtual Location? Location { get; set; }

        public int? DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department? Department { get; set; }
        public DateTime DateCreated { get; set; }

        [Required]
        public string ScreenType { get; set; } // Type of screen (e.g., "TV", "LED")

        public DateTime LastUpdated { get; set; } // Last time this screen was updated
        public DateTime LastCheckedIn { get; set; } // Date and time when the screen last checked in
        public bool IsOnline { get; set; } // Whether the screen is currently online or offline
        [Required]
        public string StatusMessage { get; set; } // A message regarding the screen status
    }


}

