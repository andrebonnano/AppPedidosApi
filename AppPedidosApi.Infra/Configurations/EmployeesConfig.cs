using AppPedidosApi.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPedidosApi.Infra.Configurations
{
    internal class EmployeesConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).HasColumnType("VARCHAR(80)").IsRequired();
            builder.Property(c => c.Email).HasColumnType("VARCHAR(80)").IsRequired();
            builder.Property(c => c.Password).HasColumnType("VARCHAR(20)").IsRequired();
            builder.Property(c => c.AccessCode).HasColumnType("VARCHAR(20)").IsRequired();
            builder.Property(c => c.Active).HasColumnType("bit").IsRequired();

        }
    }
}
