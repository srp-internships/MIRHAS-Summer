using OnlineEcommerce.Shared.Models;

namespace OnlineEcommerce.Client.Services.CategoryService
{
    public interface ICategoryService
    {
        List<Category> Categories { get; }
        Task<List<Category>> GetCategories();
    }
}
