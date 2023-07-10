using Domain.Models;
using Domain.Repository;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class ProductRepository : Repository<Product>, IProductsRepository
    {
        public ProductRepository(SkladContext context) : base(context)
        {
        }

        public IEnumerable<Product> GetProductsIncludeAllOrders()
        {
            return context.Products
                .Include(p => p.MyOrders)
                .Include(p => p.CustomerOrders);

        }

        public void Remove(int id)
        {
            var entity = context.Products.Find(id);
            Remove(entity);
        }

        public void Remove(Product product)
        {
            context.Remove(product);
        }

        public void Update(Product entity)
        {
            var product = context.Products.Find(entity.Id);
            if (product == null)
            {
                throw new Exception("Product not found");
            }
            product.Name = entity.Name;
            product.ProviderId = entity.ProviderId;
        }
    }
}
