using AppPedidosApi.Application.Interfaces.Users;
using AppPedidosApi.Application.Requests;
using AppPedidosApi.Context;
using AppPedidosApi.Domain.Entities.Users;
using Microsoft.AspNetCore.Mvc;

namespace AppPedidosApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomersController : ControllerBase
    {

        /*Customer pessoa1 = new("André", "andre@bonnano.com.br", "284.349.448-63", "11 96631-1221", "123456");
        Customer pessoa2 = new("Mari", "mari@bonnano.com.br", "312.715.828-99", "11 96621-3663", "123456");
        List<Customer> pessoas = new();*/

        private readonly ILogger<CustomersController> _logger;
        private readonly ICustomerRepo _customerRepo;

        public CustomersController(ILogger<CustomersController> logger, ICustomerRepo customerRepo)
        {
            _logger = logger;
            _customerRepo = customerRepo;
            
            /*Address endereco = new(pessoa1.Id, "Minha Casa", "Rua das Cegonhas, 208", "Ap. 302", "Pedra Branca", "Palhoça", "SC", "Brasil");
            Address endereco2 = new(pessoa2.Id, "Meu escritório", "Rua das Cegonhas, 208", "Ap. 302", "Pedra Branca", "Palhoça", "SC", "Brasil");
            pessoa1.AddAdress(endereco);
            pessoa2.AddAdress(endereco2);
            pessoas.Add(pessoa1);
            pessoas.Add(pessoa2);*/
        }

        [HttpGet(Name = "GetCustomers")]
        public async Task<IActionResult> GetAll([FromQuery] GetCustomersRequest request)
        {
            var pessoa = _customerRepo.GetCustomerAllAsync();
            return Ok(pessoa);
        }

        [HttpGet("{email}", Name = "GetCustomer")]
        /*public Customer GetOne([FromRoute] string email)
        {
            var customer = pessoas.FirstOrDefault(p => p.Email == email);

            return customer!;
        }*/

        [HttpPost(Name = "AddCustomer")]
        public Customer Add(Customer customer)
        {
            _customerRepo.AddCustomerAsync(customer);
            return customer;
        }
    }
}
