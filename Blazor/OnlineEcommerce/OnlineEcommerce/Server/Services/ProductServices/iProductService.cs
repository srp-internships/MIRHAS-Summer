using OnlineEcommerce.Shared;

namespace OnlineEcommerce.Server.Services.ProductServices
{
    public interface IProductService
    {
        Task<ServiceResponce<List<Product>>> GetProducts();
        Task<ServiceResponce<Product>> GetProduct(int id);
        Task<ServiceResponce<List<Product>>> GetProductsByCategory(string categoryUrl);
        Task<ServiceResponce<List<Product>>> SearchProduct(string text);
        Task<ServiceResponce<List<string>>> GetSearchSuggestions(string text);
    }
}
