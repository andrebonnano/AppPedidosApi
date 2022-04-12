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

        [HttpGet(Name = "GetAllProducts")]
        public List<Product> GetAll()
        {
            return _productRepo.GetProductAll();
        }

        [HttpGet("{id}", Name = "GetProduct")]
        public Product GetOne([FromRoute] Guid id)
        {
            return _productRepo.GetProductById(id);
        }

        [HttpPost("{id}", Name = "DisableProduct")]
        public String DisableProduct([FromRoute] Guid id)
        {
            _productRepo.DisableProduct(id);
            return $"Produto está desativado!";
        }

        [HttpPost(Name = "AddProduct")]
        public Product Add(Product product)
        {
            _productRepo.AddProduct(product);
            return product;
        }

        [HttpPut("{id}", Name = "EditProduct")]
        public Product Edit([FromRoute] Guid id, [FromBody] Product product)
        {
            _productRepo.UpdateProduct(id, product);
            return product;
        }
    }
}