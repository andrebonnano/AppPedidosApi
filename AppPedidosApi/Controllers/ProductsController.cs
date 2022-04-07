using AppPedidosApi.Domain.Entities.Products;
using Microsoft.AspNetCore.Mvc;

namespace AppPedidosApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        readonly Product produto1 = new("Computador", "Computador de ultima geração", 2540.90);
        readonly Product produto2 = new("Notebook", "Notebook mais fino", 3820.70);
        readonly List<Product> products = new();

        

        private readonly ILogger<ProductsController> _logger;

        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
            products.Add(produto1);
            products.Add(produto2);
        }


        [HttpGet(Name = "GetProducts")]
        public List<Product> GetAll()
        {            
            return products;
        }

        [HttpGet("{name}", Name = "GetProduct")]
        public Product GetOne([FromRoute] string name)
        {
            var product = products.FirstOrDefault(p => p.Name == name);

            return product!;
        }


        [HttpPost(Name = "AddProduct")]
        public string Add(Product product)
        {
            products.Add(product);
            return "Produto adicionado com sucesso!";
        }
    }
}