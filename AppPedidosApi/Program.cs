using AppPedidosApi.Domain.Entities.Products;
using AppPedidosApi.Domain.Entities.Orders;
using AppPedidosApi.Domain.Entities.Users;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// ///////////////////////////////////////////////////// //
Customer pessoa = new("André", "andre@bonnano.com.br", "284.349.448-63", "11 96631-1221", "123456");
Address endereco = new("Minha Casa", "Rua das Cegonhas, 208", "Ap. 302", "Pedra Branca", "Palhoça", "SC", "Brasil");
Address endereco2 = new("Meu escritório", "Rua das Cegonhas, 208", "Ap. 302", "Pedra Branca", "Palhoça", "SC", "Brasil");
pessoa.AddAdress(endereco, pessoa.Id);
pessoa.AddAdress(endereco2, pessoa.Id);

Order pedido = new(pessoa.Id, pessoa.Adresses[0].Id);
Product produto1 = new("Computador", "Computador de ultima geração", 2540.90);
Product produto2 = new("Notebook", "Notebook mais fino", 3820.70);
pedido.AddItem(produto1, 2);
pedido.AddItem(produto2, 1);

foreach (var item in pedido.Items)
{
    Console.WriteLine(item.Product.Name);
}

pedido.AddItem(produto2, 4);

Console.WriteLine("Criado em: " + pedido.Insert.Moment);
foreach (var item in pedido.Edit)
{
    Console.WriteLine("Editado em: " + item.Moment);
}
// /////////////////////////////////////////////////// //

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
