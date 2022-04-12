using AppPedidosApi.Domain.Entities.Orders;
using AppPedidosApi.Domain.Entities.Products;
using AppPedidosApi.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace AppPedidosApi.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Customer>? Customers { get; set; }
        public DbSet<Employee>? Employees { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order>? Orders { get; set; }
        public DbSet<OrderItem>? OrderItems { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=.,1433;Initial Catalog=pedidos;Persist Security Info=True;User ID=sa;Password=Bonano@1980;Pooling=False",
                options => options.EnableRetryOnFailure(
                     maxRetryCount: 2,
                     maxRetryDelay: TimeSpan.FromSeconds(2),
                     errorNumbersToAdd: null)
                 .MigrationsHistoryTable("MigrationsAppPedidosApi"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }        
    }
}
