
using AppPedidosApi.Application.Interfaces.Users;
using AppPedidosApi.Context;
using AppPedidosApi.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace AppPedidosApi.Infra.Repositories
{
    internal class CustomerRepo : ICustomerRepo
    {
        private readonly ApplicationDbContext _context;

        public CustomerRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Customer> AddAsync(Customer newCustomer)
        {
            _context.Customers.Add(newCustomer);
            await _context.SaveChangesAsync();
            return newCustomer;
        }
        public async Task<Customer> UpdateAsync(Customer customer)
        {
            _context.Customers.Attach(customer);
            _context.Entry(customer).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return customer;
        }

        public async Task<List<Customer>> GetAllAsync()
        {
            return await _context.Customers.ToListAsync();
        }

        public async Task<Customer> GetByEmailAsync(string email)
        {
            return await _context.Customers.FirstAsync(x => x.Email == email);
        }

        public async Task<Customer> GetByIdAsync(Guid id)
        {
            return await _context.Customers.FirstAsync(x => x.Id == id);
        }

    }
}
