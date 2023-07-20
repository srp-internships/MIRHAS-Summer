using OnlineEcommerce.Shared;

namespace OnlineEcommerce.Server.Services.CategoryServices
{
    public interface ICategoryService
    {
        Task<ServiceResponce<List<Category>>> GetCategories();
    }
}
