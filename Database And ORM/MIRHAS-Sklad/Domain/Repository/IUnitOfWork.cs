namespace Domain.Repository
{
    public interface IUnitOfWork
    {
        ICustomerOrderRepository CustomerOrders { get; set; }
        ICustomerRepository Customers { get; set; }
        IMyOrderRepository MyOrders { get; set; }
        IProductsRepository Products { get; set; }
        IProviderRepository Providers { get; set; }

        void SaveChanges()
        {

        }
    }
}
