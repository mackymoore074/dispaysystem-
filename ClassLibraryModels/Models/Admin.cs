using ClassLibraryModels.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace ClassLibraryModels.Models
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; } // Hashed password for security
        public Role Role { get; set; } // e.g., "SuperAdmin", "Admin"

        // Foreign key properties for related entities
        public int? AgencyId { get; set; }
        [Required]
        public Agency Agency { get; set; } // Navigation property for Agency

        public int? DepartmentId { get; set; }
        [Required]
        public Department Department { get; set; } // Navigation property for Department

        public int? LocationId { get; set; }
        [Required]
        public Location Location { get; set; } // Navigation property for Location

        public int? ScreenId { get; set; }
        [Required]
        public Screen Screen { get; set; } // Navigation property for Screen

        public DateTime DateCreated { get; set; } // Date the admin was created
        public DateTime LastLogin { get; set; } // Date the admin last logged in
    }

    public enum Role
    {
        SuperAdmin, // User with super admin rights
        Admin // User with admin rights
    }
}
