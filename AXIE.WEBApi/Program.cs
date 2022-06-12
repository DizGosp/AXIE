using AXIE.Models;
using AXIE.Models.AppUsers;
using AXIE.WEBApi.Interfaces;
using AXIE.WEBApi.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using NPOI.SS.Formula.Functions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Dependency
builder.Services.AddScoped<IGlobalService<Class1>, GlobalService>();
builder.Services.AddScoped<IAccountService, AccountService>();
builder.Services.AddScoped<IAccountRoninService, AccountRoninService>();
//builder.Services.AddScoped<IPasswordHasher<T>, PasswordHasher<T>>();
//builder.Services.AddScoped<IAuthentificationService, AuthentificationService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthentication();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
