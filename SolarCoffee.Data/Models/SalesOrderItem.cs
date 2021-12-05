namespace SolarCoffee.Data.Models
{
    public class SalesOrderItem : BaseEntity
    {
        public int Quantity { get; set; }
        public Product? Product { get; set; }
        public SalesOrder? SalesOrder { get; set; }
    }
}
