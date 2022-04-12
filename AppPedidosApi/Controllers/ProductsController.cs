using AppPedidosApi.Application.Interfaces.Products;
using AppPedidosApi.Context;
using AppPedidosApi.Domain.Entities.Products;
using AppPedidosApi.Infra.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AppPedidosApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        ProductRepo _productRepo = new();
        ApplicationDbContext _db = new ApplicationDbContext();

        private readonly ILogger<ProductsController> _logger;

        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetProducts")]
        public List<Product> GetAll()
        {
            return _productRepo.GetProductAll();
            //var products = _db.Products.ToList();
            //return products;
        }

        [HttpGet("{id}", Name = "GetProduct")]
        public Product GetOne([FromRoute] Guid id)
        {
            return _productRepo.GetProductById(id);
            //return _db.Products.FirstOrDefault(p => p.Id == id);
        }

        [HttpPost("{id}", Name = "DisableProduct")]
        public String DisableProduct([FromRoute] Guid id)
        {
            Product prod = _db.Products.FirstOrDefault(p => p.Id == id);
            prod.Deactivate();
            _db.SaveChanges();
            return $"Produto {prod.Name} está desativado!";
        }

        [HttpPost(Name = "AddProduct")]
        public Product Add(Product product)
        {
            _db.Products.Add(product);
            _db.SaveChanges();
            return product;
        }

        [HttpPut("{id}", Name = "EditProduct")]
        public Product Edit([FromRoute] Guid id, [FromBody] Product product)
        {
            Product prod = _db.Products.FirstOrDefault(p => p.Id == id);
            prod.Update(prod.Name, prod.Description, prod.Price);
            _db.Update(prod);
            return prod;
        }
    }
}