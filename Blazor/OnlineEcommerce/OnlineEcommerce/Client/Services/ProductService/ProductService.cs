using OnlineEcommerce.Shared;
using OnlineEcommerce.Shared.Models;
using System.Net.Http.Json;

namespace OnlineEcommerce.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        HttpClient client;

        public event Action ProductChanged;

        public ProductService(HttpClient client)
        {
            this.client = client;
        }
        public ProductsGetResult Result { get; set; }
        public async Task GetProducts()
        {
            var responce = await client.GetFromJsonAsync<ServiceResponce<ProductsGetResult>>("api/product");
            Result = responce.Data;
            ProductChanged.Invoke();
        }
        public async Task<ServiceResponce<Product>> GetProduct(int id)
        {
            var responce = await client.GetFromJsonAsync<ServiceResponce<Product>>($"api/product/{id}");

            return responce;
        }
        public async Task GetProductByCategory(string categoryUrl)
        {
            var responce = await client.GetFromJsonAsync<ServiceResponce<ProductsGetResult>>($"api/product/getByCategory/{categoryUrl}");
            Result = responce.Data;
            ProductChanged.Invoke();
        }
        public async Task<ServiceResponce<List<string>>> GetSearchSuggestions(string text)
        {
            var responce = await client.GetFromJsonAsync<ServiceResponce<List<string>>>($"api/product/search/getSuggestions/{text}");
            return responce;
        }
        public async Task GetSearchProducts(string text)
        {
            var responce = await client.GetFromJsonAsync<ServiceResponce<ProductsGetResult>>($"api/product/search/{text}");
            Result = responce.Data;
            ProductChanged.Invoke();
        }
        public async Task<List<Product>> GetFeaturedProducts()
        {
            var responce = await client.GetFromJsonAsync<ServiceResponce<List<Product>>>("api/product/featured");

            return responce.Data;
        }
    }
}
