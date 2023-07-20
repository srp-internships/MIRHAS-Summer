using OnlineEcommerce.Shared;
using OnlineEcommerce.Shared.Models;
using System.Net.Http.Json;

namespace OnlineEcommerce.Client.Services.ProductService
{
    public class ProductService : IPRoductService
    {
        HttpClient client;

        public event Action ProductChanged;

        public ProductService(HttpClient client)
        {
            this.client = client;
        }
        public List<Product> Products { get; set; }
        public async Task GetProducts()
        {
            var responce = await client.GetFromJsonAsync<ServiceResponce<List<Product>>>("api/product");
            Products = responce.Data;
            ProductChanged.Invoke();
        }
        public async Task<ServiceResponce<Product>> GetProduct(int id)
        {
            var responce = await client.GetFromJsonAsync<ServiceResponce<Product>>($"api/product/{id}");

            return responce;
        }
        public async Task GetProductByCategory(string categoryUrl)
        {
            var responce = await client.GetFromJsonAsync<ServiceResponce<List<Product>>>($"api/product/getByCategory/{categoryUrl}");
            Products = responce.Data;
            ProductChanged.Invoke();
        }
        public async Task<ServiceResponce<List<string>>> GetSearchSuggestions(string text)
        {
            var responce = await client.GetFromJsonAsync<ServiceResponce<List<string>>>($"api/product/search/getSuggestions/{text}");
            return responce;
        }
        public async Task GetSearchProducts(string text)
        {
            var responce = await client.GetFromJsonAsync<ServiceResponce<List<Product>>>($"api/product/search/{text}");
            Products = responce.Data;
            ProductChanged.Invoke();
        }
    }
}
