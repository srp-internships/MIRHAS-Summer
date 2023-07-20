using OnlineEcommerce.Shared;
using OnlineEcommerce.Shared.Models;

namespace OnlineEcommerce.Client.Services.ProductService
{
    public interface IPRoductService
    {
        event Action ProductChanged;
        List<Product> Products { get; set; }
        Task GetProducts();
        Task<ServiceResponce<Product>> GetProduct(int id);
        Task GetProductByCategory(string categoryUrl);
        Task<ServiceResponce<List<string>>> GetSearchSuggestions(string text);
        Task GetSearchProducts(string text);
    }
}
