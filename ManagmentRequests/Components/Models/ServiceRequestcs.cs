using System.ComponentModel.DataAnnotations;

namespace ManagmentRequests.Components.Models
{
    public class ServiceRequestcs
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int ElevatorID { get; set; }

        [Required]
        public int PartID { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        [MaxLength(500)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string Type { get; set; } = string.Empty; // e.g., "Maintenance", "Repair"

        [Required]
        [MaxLength(50)]
        public string Status { get; set; } = string.Empty; // e.g., "Open", "Assigned", "In Progress", "Completed"

        public int? AssignedTechnicianID { get; set; } //Technicians can be unassigned

        [Required]
        [MaxLength(50)]
        public string Priority { get; set; } = string.Empty; // e.g., "High", "Medium", "Low"

        public DateTime? ResolutionDate { get; set; } // Nullable because it might not be resolved yet

        [MaxLength(500)]
        public string Notes { get; set; } = string.Empty;

        // Navigation properties
        public Elevator? Elevator { get; set; }
        public Part? Part { get; set; }
        public Technician? AssignedTechnician { get; set; }
    }
}
