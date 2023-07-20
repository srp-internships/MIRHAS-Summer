using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace OnlineEcommerce.Shared.Models
{
    public class ProductVariant
    {
        [Key]
        public int Id { get; set; }
        [JsonIgnore]
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public ProductType ProductType { get; set; }
        public int ProductTypeId { get; set; }
        public decimal Price { get; set; }
        public decimal OriginalPrice { get; set; }
    }
}
