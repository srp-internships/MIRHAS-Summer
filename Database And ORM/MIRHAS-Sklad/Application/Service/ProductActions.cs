using Application.Service.Base;
using Domain.Models;
using Infrastructure.Repository;

namespace Application.Service
{
    public class ProductActions : DbExtraActions<Product>
    {
        public ProductActions(UnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        public List<Product> GetAllProductsWithOrders()
        {
            return unitOfWork.Products.GetProductsIncludeAllOrders().ToList();
        }

        public override void Update(Product entity)
        {
            unitOfWork.Products.Update(entity);
            unitOfWork.SaveChanges();
        }
    }
}
