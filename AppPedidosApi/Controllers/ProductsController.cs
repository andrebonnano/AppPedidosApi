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

        private readonly ILogger<ProductsController> _logger;

        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        [HttpPost("Add", Name = "AddProduct", Order = 1)]
        public Product Add(Product product)
        {
            _productRepo.AddProduct(product);
            return product;
        }

        [HttpPut("Edit/{id}", Name = "EditProduct", Order = 2)]
        public Product Edit([FromRoute] Guid id, [FromBody] Product product)
        {
            _productRepo.UpdateProduct(id, product);
            return product;
        }

        [HttpPost("Disable/{id}", Name = "DisableProduct", Order = 3)]
        public String DisableProduct([FromRoute] Guid id)
        {
            _productRepo.DisableProduct(id);
            return $"Produto está desativado!";
        }

        [HttpGet("GetAll", Name = "GetAllProducts", Order = 4)]
        public List<Product> GetAll()
        {
            return _productRepo.GetProductAll();
        }

        [HttpGet("Get/{id}", Name = "GetProduct", Order = 5)]
        public Product GetOne([FromRoute] Guid id)
        {
            return _productRepo.GetProductById(id);
        }
    }
}