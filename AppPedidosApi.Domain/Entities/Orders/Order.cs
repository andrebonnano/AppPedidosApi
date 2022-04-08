
using AppPedidosApi.Domain.Entities.Products;
using AppPedidosApi.Domain.Enums;

namespace AppPedidosApi.Domain.Entities.Orders
{
    public class Order 
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public DateTime Date { get; private set; }
        public Guid CustomerId { get; private set; }
        public Guid AddressId { get; private set; }
        public List<OrderItem> Items { get; private set; } = new();
        public OrderStatus Status { get; private set; }

        public Order()
        {
        }

        public Order(Guid customerId, Guid addressId)
        {
            CustomerId = customerId;
            AddressId = addressId;
            Status = OrderStatus.Created;
            Date = DateTime.Now;
        }

        public void AddItem(Product product, int quantity)
        {
            OrderItem item = new();
            item.AddProduct(Id, product, quantity);
            Items.Add(item);

        }

        public List<OrderItem> GetAllProducts()
        {
            return Items;
        }

        public double GetTotalPrice()
        {
            return GetTotalPrice();
        }
    }
}
