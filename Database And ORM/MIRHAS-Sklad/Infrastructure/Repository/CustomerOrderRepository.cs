using Domain.Models;
using Domain.Repository;
using Infrastructure.Data;

namespace Infrastructure.Repository
{
    public class CustomerOrderRepository : Repository<CustomerOrder>, ICustomerOrderRepository
    {
        public CustomerOrderRepository(SkladContext context) : base(context)
        {
        }
    }
}
