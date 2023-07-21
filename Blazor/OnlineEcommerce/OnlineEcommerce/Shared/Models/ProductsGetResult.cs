namespace OnlineEcommerce.Shared.Models
{
    public class ProductsGetResult
    {
        public List<List<Product>> Pages { get; set; } = new List<List<Product>>();
        public int CurrentPage { get; set; } = 0;
    }
}
