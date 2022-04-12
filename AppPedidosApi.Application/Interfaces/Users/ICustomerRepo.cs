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
        Customer GetCustomerByEmail(string email);
        Customer GetCustomerById(Guid id);
        List<Customer> GetCustomerAll();
        Customer AddCustomer(Customer newCustomer);
        Customer UpdateCustomer(Customer customer);


    }
}
