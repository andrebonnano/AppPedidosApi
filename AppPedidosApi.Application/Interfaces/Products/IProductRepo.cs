using AppPedidosApi.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPedidosApi.Application.Interfaces.Products
{
    internal interface IProductRepo
    {
        Task<Product> GetProductByIdAsync(Guid id);
        Task<Product> GetProductByNameAsync(string name);
        Task<List<Product>> GetProductAllAsync();
        Task<Product> AddProductAsync(Product newProduct);
        Task<Product> UpdateProductAsync(Guid id);
        Task<Product> DisableProductAsync(Guid id);
    }
}
