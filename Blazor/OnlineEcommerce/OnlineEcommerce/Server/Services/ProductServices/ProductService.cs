using Microsoft.EntityFrameworkCore;
using OnlineEcommerce.Server.Data;
using OnlineEcommerce.Shared;

namespace OnlineEcommerce.Server.Services.ProductServices
{
    public class ProductService : IProductService
    {
        ShopContext _context;
        public ProductService(ShopContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponce<Product>> GetProduct(int id)
        {
            var responce = new ServiceResponce<Product>();
            var product = await _context.Products
                .Include(p => p.Variants)
                .ThenInclude(p => p.ProductType)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (product == null)
            {
                responce.Success = false;
                responce.Message = "Sorry. But product not found";
            }
            else
            {
                responce.Data = product;
            }
            return responce;
        }
        public async Task<ServiceResponce<List<Product>>> GetProducts()
        {
            var responce = new ServiceResponce<List<Product>>();
            var products = await _context.Products.Include(p => p.Variants).ToListAsync();

            if (products != null)
                responce.Data = products;
            else
            {
                responce.Success = false;
                responce.Message = "There is no data in the database";
            }

            return responce;

        }
        public async Task<ServiceResponce<List<Product>>> GetProductsByCategory(string categoryUrl)
        {
            var responce = new ServiceResponce<List<Product>>();

            var allProducts = await _context.Products
                .Include(p => p.Category)
                .Include(p => p.Variants)
                .ToListAsync();

            var products = (from p in allProducts
                            where p.Category.Url == categoryUrl
                            select p).ToList();

            if (products is null)
            {
                responce.Success = false;
                responce.Message = "There are no products with this category";
            }
            else responce.Data = products;

            return responce;
        }

        public async Task<ServiceResponce<List<string>>> GetSearchSuggestions(string text)
        {
            var products = await Search(text);
            var responce = new ServiceResponce<List<string>>()
            {
                Data = (from p in products
                        select p.Title).ToList()
            };

            return responce;
        }
        public async Task<ServiceResponce<List<Product>>> SearchProduct(string text)
        {
            var responce = new ServiceResponce<List<Product>>()
            {
                Data = await Search(text)
            };
            return responce;
        }

        async Task<List<Product>> Search(string text)
        {
            var products = await _context.Products.Include(p => p.Variants)
                .Where(p => p.Title.ToLower().Contains(text.ToLower()) ||
                p.Description.ToLower().Contains(text.ToLower()))
                .ToListAsync();
            return products;
        }
    }
}
