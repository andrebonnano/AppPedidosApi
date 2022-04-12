using AppPedidosApi.Domain.Entities.Users;
using AppPedidosApi.Infra.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AppPedidosApi.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class AddressController : ControllerBase
    {
        AddressRepo _addressRepo = new();

        private readonly ILogger<AddressController> _logger;

        public AddressController(ILogger<AddressController> logger)
        {
            _logger = logger;

        }

        [HttpPost("Add", Name = "AddAddress")]
        public Address AddAddress([FromBody] Address address)
        {
            _addressRepo.AddAddress(address);
            return address;
        }

        [HttpGet("GetFrom/{id}", Name ="GetUserAdresses")]
        public List<Address> GetUserAdresses([FromRoute] Guid id)
        {
            return _addressRepo.GetAddressByUserId(id);
        }
    }
}
