using AppPedidosApi.Application.Interfaces.Products;
using AppPedidosApi.Infra.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPedidosApi.Infra.Setup
{
    public static class AppPedidosSetup
    {
        public static void SetupAppPedidos(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<IProductRepo, ProductRepo>();
        }
        
    }
}
