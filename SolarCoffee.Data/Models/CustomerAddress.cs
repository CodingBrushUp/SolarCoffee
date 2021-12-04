using System.ComponentModel.DataAnnotations;

namespace SolarCoffee.Data.Models
{
    public class CustomerAddress : BaseEntity
    {
        [MaxLength(100)]
        public string? AddressLine1 { get; set; }
        
        [MaxLength(100)]
        public string? AddressLine2 { get; set;}
        
        [MaxLength(100)]
        public string? City { get; set; }
        
        [MaxLength(2)]
        public string? State { get; set; }
        
        [MaxLength(10)]
        public string? PostalCode { get; set; }
        
        [MaxLength(100)]
        public string? Country { get; set; }
    }
}