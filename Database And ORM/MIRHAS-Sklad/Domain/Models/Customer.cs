namespace Domain.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public IEnumerable<CustomerOrder> CustomerOrders { get; set; }
    }
}
