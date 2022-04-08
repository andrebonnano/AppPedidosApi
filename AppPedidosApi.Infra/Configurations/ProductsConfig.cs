
using AppPedidosApi.Domain.Entities.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppPedidosApi.Infra.Configurations
{
    internal class ProductsConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).HasColumnType("varchar(30)");
            builder.Property(p => p.Description).HasColumnType("varchar(255)");
            builder.Property(p => p.Price).HasColumnType("float");
            builder.Property(p => p.IsActive).HasColumnType("bit");

        }
    }
}
