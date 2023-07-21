using OnlineEcommerce.Shared;

namespace OnlineEcommerce.Server.Services.ProductServices
{
    public interface IProductService
    {
        Task<ServiceResponce<ProductsGetResult>> GetProducts();
        Task<ServiceResponce<Product>> GetProduct(int id);
        Task<ServiceResponce<ProductsGetResult>> GetProductsByCategory(string categoryUrl);
        Task<ServiceResponce<ProductsGetResult>> SearchProduct(string text);
        Task<ServiceResponce<List<string>>> GetSearchSuggestions(string text);
        Task<ServiceResponce<List<Product>>> GetFeaturedProducts();
    }
}
