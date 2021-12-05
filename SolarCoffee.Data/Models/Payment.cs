namespace SolarCoffee.Data.Models
{
    //create a class for Payment
    public class Payment : BaseEntity
    {
        public decimal Amount { get; set; }
        public Customer? Customer { get; set; }
    }
}
