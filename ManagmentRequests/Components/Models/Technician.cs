using System.ComponentModel.DataAnnotations;

namespace ManagmentRequests.Components.Models
{
    public class Technician
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Fullname { get; set; } = string.Empty;

        [Required]
        [MaxLength(20)]
        [Phone] // Added Phone attribute for validation
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        [EmailAddress] // Added EmailAddress attribute for validation
        public string Email { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string Specialization { get; set; } = string.Empty; // e.g., "Electrical", "Mechanical"

        [Required]
        public DateTime HireDate { get; set; }
    }
}
