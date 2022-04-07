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
        Task<Customer> GetByEmailAsync(string email);
        Task<Customer> GetByIdAsync(Guid id);
        Task<List<Customer>> GetAllAsync();
        Task<Customer> AddAsync(Customer newCustomer);
        Task<Customer> UpdateAsync(Customer customer);


    }
}
