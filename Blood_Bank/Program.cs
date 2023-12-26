using Blood_Bank;
using Blood_Bank.Core.Repositories;
using Blood_Bank.Core.Entities;
using Blood_Bank.Data;
using Blood_Bank.Data.Repositories;
using Blood_Bank.Service;
using DataContext = Blood_Bank.Data.DataContext;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>();

builder.Services.AddScoped<DonationsService>();
builder.Services.AddScoped<DonorsService>();
builder.Services.AddScoped<SicksService>();
builder.Services.AddScoped<IDonationsRepositories, DonationsReposotory>();
builder.Services.AddScoped<IDonorsRepositories, DonorsReposotory>();
builder.Services.AddScoped<ISicksRepositories, SicksReposotory>();
builder.Services.AddSingleton<DataContext>();


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
