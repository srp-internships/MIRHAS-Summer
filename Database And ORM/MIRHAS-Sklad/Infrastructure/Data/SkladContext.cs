using Domain.Models;
using Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class SkladContext : DbContext
    {
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CustomerOrder> CustomerOrders { get; set; }
        public DbSet<MyOrder> MyOrders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Intern\\Desktop\\MIRHAS-Summer\\Database And ORM\\MIRHAS-Sklad\\Infrastructure\\Database\\SkladDB.mdf\";Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<CustomerOrder>(new CustomerOrdersConfiguration());
            modelBuilder.ApplyConfiguration<MyOrder>(new MyOrdersConfiguration());
            modelBuilder.ApplyConfiguration<Product>(new ProductConfiguration());
        }
    }
}
