
using System.ComponentModel.DataAnnotations;

namespace modul19_opg.Shared.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Name must be less than 50 characters.")]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        public string Description { get; set; }

        public bool IsPublished { get; set; }

        public DateTime PublishedDate { get; set; } = DateTime.UtcNow;
    }
}