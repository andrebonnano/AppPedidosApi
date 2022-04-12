using AppPedidosApi.Context;
using AppPedidosApi.Application.Interfaces.Products;
using AppPedidosApi.Domain.Entities.Products;

namespace AppPedidosApi.Infra.Repositories
{
    public class ProductRepo : IProductRepo
    {
        ApplicationDbContext _db = new ApplicationDbContext();

        public Product AddProduct(Product newProduct)
        {
            _db.Products.Add(newProduct);
            _db.SaveChanges();
            return newProduct;
        }

        public string DisableProduct(Guid id)
        {
            Product prod = _db.Products.FirstOrDefault(p => p.Id == id);
            prod.Deactivate();
            _db.SaveChanges();
            return $"Produto {prod.Name} está desativado!";
        }

        public List<Product> GetProductAll()
        {
            var products = _db.Products.ToList();
            return products;
        }

        public Product GetProductById(Guid id)
        {
            return _db.Products.FirstOrDefault(p => p.Id == id);
        }

        public Product UpdateProduct(Guid id, Product product)
        {
            Product prod = _db.Products.FirstOrDefault(p => p.Id == id);
            prod = product;
            _db.SaveChanges();
            return prod;

        }
    }
}
