using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class CustomerOrder
    {
        public int Id { get; set; }
        public Product Product { get; set; } = null!;
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalSellingPrice { get; set; }
        public decimal TotalBuyingPrice { get; set; }
        public decimal IncomeFromThisOrder { get; set; }
        public Customer Customer { get; set; } = null!;
        public int CustomerId { get; set; }
    }
}