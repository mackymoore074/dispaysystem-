using System.ComponentModel.DataAnnotations;

namespace ClassLibraryModels.Models
{
    public class AllowedIpAddress
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(45)]  // IPv6 addresses can be up to 45 characters
        public string IpAddress { get; set; }

        public int LocationId { get; set; }
        public Location Location { get; set; }
    }
} 