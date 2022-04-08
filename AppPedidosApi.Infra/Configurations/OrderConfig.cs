
using AppPedidosApi.Domain.Entities.Orders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppPedidosApi.Infra.Configurations
{
    internal class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Date).HasColumnType("datetime");
            builder.Property(t => t.AddressId);
            builder.Property(t => t.Status).HasColumnType("varchar(30)");

            builder.HasMany(t => t.Items);
        }
    }
}
