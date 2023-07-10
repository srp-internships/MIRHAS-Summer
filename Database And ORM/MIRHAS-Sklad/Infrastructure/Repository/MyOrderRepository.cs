using Domain.Models;
using Domain.Repository;
using Infrastructure.Data;

namespace Infrastructure.Repository
{
    public class MyOrderRepository : Repository<MyOrder>, IMyOrderRepository
    {
        public MyOrderRepository(SkladContext context) : base(context)
        {
        }
    }
}
