using AppPedidosApi.Domain.Entities.Products;

namespace AppPedidosApi.Domain.Entities.Orders
{
    public class OrderItem
    {
        public Guid Id { get; private set; } = new Guid();
        public Guid OrderId { get; private set; }
        public Product Product { get; private set; }
        public int Quantity { get; private set; }
        public double TotalPrice { get; private set; }

        public OrderItem(Product product, int quantity, Guid orderId)
        {
            Product = product;
            Quantity = quantity;
            OrderId = orderId;
            TotalPrice = product.Price * quantity;
        }
    }
}
