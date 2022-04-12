using AppPedidosApi.Application.Interfaces.Users;
using AppPedidosApi.Context;
using AppPedidosApi.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace AppPedidosApi.Infra.Repositories
{
    public class CustomerRepo : ICustomerRepo
    {
        private readonly ApplicationDbContext _db = new ApplicationDbContext();

        public Customer AddCustomer(Customer newCustomer)
        {
            _db.Customers.Add(newCustomer);
            _db.SaveChangesAsync();
            return newCustomer;
        }
        public Customer UpdateCustomer(Customer customer)
        {
            _db.Customers.Attach(customer);
            _db.Entry(customer).State = EntityState.Modified;
            _db.SaveChangesAsync();
            return customer;
        }

        public List<Customer> GetCustomerAll()
        {
            return _db.Customers.ToList();
        }

        public Customer GetCustomerByEmail(string email)
        {
            return _db.Customers.First(x => x.Email == email);
        }

        public Customer GetCustomerById(Guid id)
        {
            return _db.Customers.First(x => x.Id == id);
        }

    }
}
