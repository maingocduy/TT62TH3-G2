﻿using Microsoft.EntityFrameworkCore;
using WebApplication3.Controllers.Data;
using WebApplication3.Service.AccountService;
using WebApplication3.Service.SponsorService;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseMySql(builder.Configuration.GetConnectionString("AppDbContext"),
                     new MySqlServerVersion(new Version(8, 0, 36))); // Thay thế version MySQL tương ứng
});
builder.Services.AddScoped<IAccountService, AccountService>();
builder.Services.AddScoped<ISponsorService, SponsorService>();
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
