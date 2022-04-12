using AppPedidosApi.Application.Interfaces.Users;
using AppPedidosApi.Domain.Entities.Users;
using AppPedidosApi.Infra.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AppPedidosApi.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class CustomersController : ControllerBase
    {
        CustomerRepo _customerRepo = new();

        private readonly ILogger<CustomersController> _logger;

        public CustomersController(ILogger<CustomersController> logger)
        {
            _logger = logger;
        }

        [HttpPost("Add", Name = "AddCustomer")]
        public Customer AddCustomer(Customer customer)
        {
            _customerRepo.AddCustomer(customer);
            return customer;
        }

        [HttpPut("Edit", Name = "EditCustomer")]
        public Customer UpdateCustomer([FromBody] Customer customer)
        {
            return _customerRepo.UpdateCustomer(customer);
        }

        [HttpGet("GetAll", Name = "GetCustomers")]
        public List<Customer> GetCustomers()
        {
            return _customerRepo.GetCustomerAll();
        }

        [HttpGet("Get/{email}", Name = "GetCustomerByEmail")]
        public Customer GetCustomerByEmail([FromRoute] string email)
        {
            return _customerRepo.GetCustomerByEmail(email);
        }





    }
}
