using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class MyOrdersConfiguration : IEntityTypeConfiguration<MyOrder>
    {
        public void Configure(EntityTypeBuilder<MyOrder> builder)
        {
            builder.HasIndex(s => s.ProductId).IsUnique(false);

            builder.HasAlternateKey(nameof(MyOrder.ProductId));
            //builder.HasAlternateKey(nameof(MyOrder.))
            builder.HasOne<Product>()
                .WithMany();
        }
    }
}
