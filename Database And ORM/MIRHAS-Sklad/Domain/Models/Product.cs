namespace Domain.Models
{
    public class Product                                        
    {                                                           
        public int Id { get; set; }                             
        public string Name { get; set; } = null!;               
        public int Quantity { get; set; }                     
        public int ProviderId { get; set; }              
        public Provider Provider { get; set; } = null!;
        public List<MyOrder>? MyOrders { get; set; }            
        public List<CustomerOrder>? CustomerOrders { get; set; }
    }
}
