using Microsoft.EntityFrameworkCore;
using OnlineEcommerce.Server.Data;
using OnlineEcommerce.Shared;

namespace OnlineEcommerce.Server.Services.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        ShopContext context;
        public CategoryService(ShopContext context)
        {
            this.context = context;
        }

        public async Task<ServiceResponce<List<Category>>> GetCategories()
        {
            var categories = await context.Categories.ToListAsync();

            return new ServiceResponce<List<Category>>
            {
                Data = categories
            };
        }
    }
}
