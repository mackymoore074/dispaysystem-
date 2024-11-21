using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryModels.Models
{
    public class NewsItem
    {
        public int Id { get; set; }
        public string Title { get; set; } // Title of the content
        [Required]
        [StringLength(450)]
        public string NewsItemBody { get; set; } // 450 characters 
        public string Agency { get; set; } // Associated agency (e.g., "David & Margaret")
        public List<string> Departments { get; set; } // Departments this content is relevant to
        public DateTime DateCreated { get; set; } // When the content was created
        public DateTime TimeOutDate { get; set; } // When the content should be removed from display
        public ImportanceLevel Importance { get; set; } // Importance level for frequency of display stated below
        public string MoreInformationUrl { get; set; } // Link to more information if available
        public List<Location> Locations { get; set; }

        // Constructor
        public NewsItem()
        {
            Locations = new List<Location>();
        }
        public enum ImportanceLevel
        {
            VeryImportant = 1,  // Highest priority
            SomewhatImportant = 2, // Medium priority
            LowImportance = 3 // Low priority
        }

    }
}
