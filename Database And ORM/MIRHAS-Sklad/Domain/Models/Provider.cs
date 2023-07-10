namespace Domain.Models
{
    public class Provider
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public override string ToString()
        {
            return Name;
        }
        public IEnumerable<MyOrder> MyOrders { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
