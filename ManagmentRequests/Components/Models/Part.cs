using System.ComponentModel.DataAnnotations;

namespace ManagmentRequests.Components.Models
{
    public class Part
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string SerialNumber { get; set; } = string.Empty;

        [Required]
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; } //Using decimal for monetary values

        [Required]
        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }
    }
}
