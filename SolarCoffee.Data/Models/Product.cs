using System.ComponentModel.DataAnnotations;

namespace SolarCoffee.Data.Models
{
    public class Product : BaseEntity
    {
        [MaxLength(100)]
        public string? Name { get; set; }

        [MaxLength(100)]
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public bool isTaxable { get; set; }
        public bool isArchived { get; set; }
    }
}
