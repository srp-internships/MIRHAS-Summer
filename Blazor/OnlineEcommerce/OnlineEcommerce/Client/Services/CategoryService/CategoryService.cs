using OnlineEcommerce.Shared;
using OnlineEcommerce.Shared.Models;
using System.Net.Http.Json;

namespace OnlineEcommerce.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        HttpClient client;
        public CategoryService(HttpClient client)
        {
            this.client = client;
        }
        public List<Category> Categories { get; set; }
        public async Task<List<Category>> GetCategories()
        {
            var responce = await client.GetFromJsonAsync<ServiceResponce<List<Category>>>("api/category");
            Categories = responce.Data;

            return responce.Data;
        }

    }
}
