using AppPedidosApi.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppPedidosApi.Infra.Configurations
{
    internal class AdressesConfig : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Adresses");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.CustomerId);
            builder.Property(t => t.Alias).HasColumnType("varchar(20)");
            builder.Property(t => t.Street).HasColumnType("varchar(100)");
            builder.Property(t => t.Complement).HasColumnType("varchar(100)");
            builder.Property(t => t.District).HasColumnType("varchar(100)");
            builder.Property(t => t.City).HasColumnType("varchar(100)");
            builder.Property(t => t.State).HasColumnType("varchar(2)");
            builder.Property(t => t.Country).HasColumnType("varchar(100)");
        }
    }
}
