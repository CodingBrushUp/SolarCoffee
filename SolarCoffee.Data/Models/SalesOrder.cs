namespace SolarCoffee.Data.Models
{
    //create a class for SalesOrder and SalesOrderItem
    public class SalesOrder : BaseEntity
    {
        public DateTime SalesDateTime { get; set; }
        public Customer? Customer { get; set; }
        public List<SalesOrderItem>? SalesOrderItems { get; set; }
        public bool isPaid { get; set; } = false;
    }
}
