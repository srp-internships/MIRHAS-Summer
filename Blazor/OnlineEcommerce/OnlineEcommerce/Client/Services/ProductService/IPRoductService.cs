using OnlineEcommerce.Shared;
using OnlineEcommerce.Shared.Models;

namespace OnlineEcommerce.Client.Services.ProductService
{
    public interface IProductService
    {
        event Action ProductChanged;
        ProductsGetResult Result { get; set; }
        Task GetProducts();
        Task<ServiceResponce<Product>> GetProduct(int id);
        Task GetProductByCategory(string categoryUrl);
        Task<ServiceResponce<List<string>>> GetSearchSuggestions(string text);
        Task GetSearchProducts(string text);
        Task<List<Product>> GetFeaturedProducts();
    }
}
