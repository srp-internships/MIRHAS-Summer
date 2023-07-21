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

        public async Task<ServiceResponce<List<Product>>> GetFeaturedProducts()
        {
            var products = await _context.Products.Include(p => p.Variants).Where(p => p.Featured).ToListAsync();
            return new ServiceResponce<List<Product>>() { Data = products };
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
        public async Task<ServiceResponce<ProductsGetResult>> GetProducts()
        {
            var responce = new ServiceResponce<ProductsGetResult>();
            var products = await _context.Products.Include(p => p.Variants).ToListAsync();

            if (products != null)
                responce.Data = PaginateProducts(products);
            else
            {
                responce.Success = false;
                responce.Message = "There is no data in the database";
            }

            return responce;

        }
        public async Task<ServiceResponce<ProductsGetResult>> GetProductsByCategory(string categoryUrl)
        {
            var responce = new ServiceResponce<ProductsGetResult>();

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
            else responce.Data = PaginateProducts(products);

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
        public async Task<ServiceResponce<ProductsGetResult>> SearchProduct(string text)
        {
            var products = await Search(text);
            var pages = PaginateProducts(products);

            var responce = new ServiceResponce<ProductsGetResult>();
            responce.Data = pages;

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

        ProductsGetResult PaginateProducts(List<Product> products)
        {
            var pages = new List<List<Product>>();
            var page = new List<Product>();
            pages.Add(page);
            int counter = 0;
            for (int i = 0; i < products.Count; i++)
            {
                if (i / 5 == counter)
                {
                    page.Add(products[i]);
                }
                else
                {
                    page = new List<Product>();
                    page.Add(products[i]);
                    pages.Add(page);
                    counter = i / 5;
                }
            }
            return new ProductsGetResult
            {
                Pages = pages
            };
        }
    }
}
