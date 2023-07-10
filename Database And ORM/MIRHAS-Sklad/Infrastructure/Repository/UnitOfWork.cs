using Domain.Models;
using Domain.Repository;
using Infrastructure.Data;

namespace Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public ICustomerOrderRepository CustomerOrders { get; set; }
        public ICustomerRepository Customers { get; set; }
        public IMyOrderRepository MyOrders { get; set; }
        public IProductsRepository Products { get; set; }
        public IProviderRepository Providers { get; set; }

        private SkladContext context { get; set; }

        public UnitOfWork()
        {
            context = new SkladContext();
            CustomerOrders = new CustomerOrderRepository(context);
            Customers = new CustomerRepository(context);
            MyOrders = new MyOrderRepository(context);
            Products = new ProductRepository(context);
            Providers = new ProviderRepository(context);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public object Set<T>()
        {
            if (typeof(T) == typeof(CustomerOrder)) return CustomerOrders;
            if (typeof(T) == typeof(Customer)) return Customers;
            if (typeof(T) == typeof(MyOrder)) return MyOrders;
            if (typeof(T) == typeof(Product)) return Products;
            else return Providers;
        }
    }
}
