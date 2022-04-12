using AppPedidosApi.Domain.Entities.Products;
using AppPedidosApi.Domain.Entities.Orders;
using AppPedidosApi.Domain.Entities.Users;
using AppPedidosApi.Infra.Repositories;
using AppPedidosApi.Application.Interfaces.Users;
using AppPedidosApi.Application.Interfaces.Products;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddScoped<ICustomerRepo, CustomerRepo>();
//builder.Services.AddScoped<IProductRepo, ProductRepo>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
