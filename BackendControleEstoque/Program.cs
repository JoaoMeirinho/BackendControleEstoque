using BackendControleEstoque.Infra;
using BackendControleEstoque.Mapper;
using BackendControleEstoque.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using BackendControleEstoque.Repositories.Interfaces;
using BackendControleEstoque.Repositories;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(config => config.AddProfile(new AutoMapperProfile()));

var connection = builder.Configuration.GetConnectionString("defaultConnection");

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseMySql(connection, new MySqlServerVersion(new Version(8, 0, 39)));
});
builder.Services.AddIdentityCore<User>().AddEntityFrameworkStores<AppDbContext>();

builder.Services.AddScoped<IItemRepository, ItemRepository>();

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
