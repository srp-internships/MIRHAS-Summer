using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    class CustomerOrdersConfiguration : IEntityTypeConfiguration<CustomerOrder>
    {
        public void Configure(EntityTypeBuilder<CustomerOrder> builder)
        {
            builder.HasIndex(s => s.CustomerId).IsUnique(false);
            builder.HasIndex(s => s.ProductId).IsUnique(false);
            /*builder.HasAlternateKey(nameof(CustomerOrder.CustomerId));
            builder.HasAlternateKey(nameof(CustomerOrder.ProductId));
            builder.HasOne<Customer>()
                .WithMany();
            builder.HasOne<Product>()
                .WithMany();*/
        }
    }
}
