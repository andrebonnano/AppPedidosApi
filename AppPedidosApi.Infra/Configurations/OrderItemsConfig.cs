using AppPedidosApi.Domain.Entities.Orders;
using AppPedidosApi.Domain.Entities.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPedidosApi.Infra.Configurations
{
    internal class OrderItemsConfig : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.ToTable("OrderItems");
            builder.HasKey(o => o.Id);
            builder.Property(o => o.OrderId);
            builder.Property(o => o.Quantity).HasColumnType("int");

            builder.HasOne<Product>(o => o.Product);
        }
    }
}
