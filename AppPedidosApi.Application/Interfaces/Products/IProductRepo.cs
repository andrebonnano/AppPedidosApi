using AppPedidosApi.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPedidosApi.Application.Interfaces.Products
{
    public interface IProductRepo
    {
        Product GetProductById(Guid id);
        List<Product> GetProductAll();
        Product AddProduct(Product newProduct);
        Product UpdateProduct(Guid id);
        String DisableProduct(Guid id);
    }
}
