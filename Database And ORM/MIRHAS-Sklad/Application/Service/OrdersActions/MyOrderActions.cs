using Application.Service.Base;
using Domain.Models;
using Infrastructure.Repository;

namespace Application.Service.OrdersActions
{
    public class MyOrderActions : DbCoreActions<MyOrder>
    {
        private UnitOfWork unitOfWork;
        public MyOrderActions(UnitOfWork unitOfWork) : base(unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public override void Add(MyOrder entity)
        {
            base.Add(entity);
            var product = (from p in unitOfWork.Products.GetAll()
                           where entity.ProductId == p.Id
                           select p).FirstOrDefault();
            if (product != null)
            {
                product.Quantity += entity.Quantity;
                unitOfWork.SaveChanges();
            }
        }
    }
}
