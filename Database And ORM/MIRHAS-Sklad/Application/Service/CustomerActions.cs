using Application.Service.Base;
using Domain.Models;
using Infrastructure.Repository;

namespace Application.Service
{
    public class CustomerActions : DbExtraActions<Customer>
    {
        public CustomerActions(UnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public override void Update(Customer entity)
        {
            unitOfWork.Customers.Update(entity);
            unitOfWork.SaveChanges();
        }
    }
}
