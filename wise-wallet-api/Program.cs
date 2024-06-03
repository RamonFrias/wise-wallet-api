using Microsoft.EntityFrameworkCore;
using wise_wallet_api.Business.Implementations;
using wise_wallet_api.Business.Interfaces;
using wise_wallet_api.Data;
using wise_wallet_api.Repository.Implementations;
using wise_wallet_api.Repository.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        builder => builder.AllowAnyOrigin()
                          .AllowAnyMethod()
                          .AllowAnyHeader());
});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(options =>
{
#pragma warning disable CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.
    string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
#pragma warning restore CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});
builder.Services.AddScoped<IItemBusiness, ItemBusiness>();
builder.Services.AddScoped<IItemRepository, ItemRepository>();

builder.Services.AddScoped<ICardBusiness, CardBusiness>();
builder.Services.AddScoped<ICardRepository, CardRepository>();

builder.Services.AddScoped<ITableBusiness, TableBusiness>();
builder.Services.AddScoped<ITableRepository, TableRepository>();

var app = builder.Build();

if(app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowSpecificOrigin");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
