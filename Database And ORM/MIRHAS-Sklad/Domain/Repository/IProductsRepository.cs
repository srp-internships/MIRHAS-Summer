using Domain.Models;

namespace Domain.Repository
{
    public interface IProductsRepository : IEntityRepository<Product>
    {
        IEnumerable<Product> GetProductsIncludeAllOrders();
    }
}
