using AppPedidosApi.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPedidosApi.Application.Interfaces.Users
{
    internal interface IEmployeeRepo
    {
        Task<Employee> GetEmployeeByIdAsync(Guid id);
        Task<List<Employee>> GetEmployeeAllAsync();
        Task<Employee> AddEmployeeAsync(Employee newEmployee);
        Task<Employee> UpdateEmployeeAsync(Employee employee);
    }
}
