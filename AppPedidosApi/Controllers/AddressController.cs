using AppPedidosApi.Domain.Entities.Users;
using Microsoft.AspNetCore.Mvc;

namespace AppPedidosApi.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class AddressController : Controller
    {
        Customer pessoa1 = new("André", "andre@bonnano.com.br", "284.349.448-63", "11 96631-1221", "123456");
        Customer pessoa2 = new("Mari", "mari@bonnano.com.br", "312.715.828-99", "11 96621-3663", "123456");
        List<Customer> pessoas = new();

        private readonly ILogger<AddressController> _logger;

        public AddressController(ILogger<AddressController> logger)
        {
            _logger = logger;

            pessoas.Add(pessoa1);
            pessoas.Add(pessoa2);
        }

        [HttpPost(Name = "AddAddress")]
        public Customer Add(Address address, string email)
        {
            Customer customer = pessoas.FirstOrDefault(p => p.Email == email);
            customer.AddAdress(address);
            return customer;
        }
    }
}
