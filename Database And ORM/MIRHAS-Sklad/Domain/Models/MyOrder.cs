using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class MyOrder
    {
        public int Id { get; set; }

        public Product Product { get; set; } = null!;
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal SellingPrice { get; set; }
    }
}