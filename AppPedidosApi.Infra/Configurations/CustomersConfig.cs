
using AppPedidosApi.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppPedidosApi.Infra.Configurations
{
    internal class CustomersConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).HasColumnType("VARCHAR(80)").IsRequired();
            builder.Property(c => c.Email).HasColumnType("VARCHAR(80)").IsRequired();
            builder.Property(c => c.Password).HasColumnType("VARCHAR(255)").IsRequired();
            builder.Property(c => c.Cpf).HasColumnType("VARCHAR(80)").IsRequired();
            builder.Property(c => c.Phone).HasColumnType("CHAR(11)").IsRequired();
            builder.Property(c => c.Active).HasColumnType("bit").IsRequired();

            builder.HasMany(c => c.Adresses);
        }
    }
}
