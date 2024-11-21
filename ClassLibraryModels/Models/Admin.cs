using ClassLibraryModels.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace ClassLibraryModels.Models
{
    public class Admin
    {
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

        public string PasswordHash { get; set; } // Hashed password for security
        public Role Role { get; set; } // e.g., "SuperAdmin", "Admin"

        // Foreign key properties for related entities
        public int AgencyId { get; set; }
        public Agency Agency { get; set; } // Navigation property for Agency

        public int DepartmentId { get; set; }
        public Department Department { get; set; } // Navigation property for Department

        public int LocationId { get; set; }
        public Location Location { get; set; } // Navigation property for Location

        public int ScreenId { get; set; }
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
