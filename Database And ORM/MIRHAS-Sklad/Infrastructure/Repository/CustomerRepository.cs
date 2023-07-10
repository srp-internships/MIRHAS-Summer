using Domain.Models;
using Domain.Repository;
using Infrastructure.Data;

namespace Infrastructure.Repository
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(SkladContext context) : base(context) { }
        public void Remove(Customer customer)
        {
            context.Remove(customer);
        }

        public void Remove(int id)
        {
            var entity = context.Customers.Find(id);
            Remove(entity);
        }

        public void Update(Customer entity)
        {
            var customer = context.Find<Customer>(entity.Id);
            if (customer == null)
            {
                throw new Exception("Customer not found");
            }
            customer.Name = entity.Name;
            customer.Phone = entity.Phone;
        }
    }
}
