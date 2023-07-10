using Application.Service.Base;
using Domain.Models;
using Infrastructure.Repository;

namespace Application.Service.OrdersActions
{
    public class CustomerOrderActions : DbCoreActions<CustomerOrder>
    {
        private UnitOfWork unitOfWork;
        public CustomerOrderActions(UnitOfWork unitOfWork) : base(unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public override void Add(CustomerOrder entity)
        {
            base.Add(entity);
            var product = (from p in unitOfWork.Products.GetAll()
                           where entity.ProductId == p.Id
                           select p).FirstOrDefault();

            if (product == null)
            {
                throw new Exception("Product not found");
            }
            if (product.Quantity >= entity.Quantity)
            {
                throw new Exception("The quantity of the order is more than the quantity of the product in the storage");
            }
            product.Quantity -= entity.Quantity;

            var orders = (from o in product.MyOrders
                          where o.Quantity != 0
                          select o).ToList();

            int quantity = entity.Quantity;
            foreach (var order in orders)
            {
                if (order.Quantity < quantity)
                {
                    order.Quantity = 0;
                    quantity -= order.Quantity;
                }
                else if (order.Quantity >= quantity)
                {
                    order.Quantity -= quantity;
                    break;
                }
            }

            unitOfWork.SaveChanges();
        }
    }
}
