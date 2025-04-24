using System.ComponentModel.DataAnnotations;

namespace ManagmentRequests.Components.Models
{
    public class Building
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(200)]
        public string Address { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string ContactName { get; set; } = string.Empty;

        [Required]
        [MaxLength(20)]
        [Phone] // Added Phone attribute for validation
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        [EmailAddress] // Added EmailAddress attribute for validation
        public string Email { get; set; } = string.Empty;

        [Required]
        [Range(0, int.MaxValue)]
        public int CountsOfElevators { get; set; }

        [MaxLength(500)]
        public string Notes { get; set; } = string.Empty;
    }
}
