using AppPedidosApi.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPedidosApi.Application.Interfaces.Users
{
    public interface ICustomerRepo
    {
        Task<Customer> GetCustomerByEmailAsync(string email);
        Task<Customer> GetCustomerByIdAsync(Guid id);
        Task<List<Customer>> GetCustomerAllAsync();
        Task<Customer> AddCustomerAsync(Customer newCustomer);
        Task<Customer> UpdateCustomerAsync(Customer customer);


    }
}
