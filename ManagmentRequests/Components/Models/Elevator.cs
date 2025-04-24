using System.ComponentModel.DataAnnotations;

namespace ManagmentRequests.Components.Models
{
    public class Elevator
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int BuildingID { get; set; }

        [Required]
        [MaxLength(50)]
        public string SerialNumber { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string Manufacture { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string Model { get; set; } = string.Empty;

        [Required]
        [Range(0, double.MaxValue)]
        public double Capacity { get; set; }

        [MaxLength(500)]
        public string Notes { get; set; } = string.Empty;

        // Navigation property
        public Building? Building { get; set; }
    }
}
