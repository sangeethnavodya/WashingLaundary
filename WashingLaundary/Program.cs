using Microsoft.EntityFrameworkCore;
using WashingLaundary.Data;
using WashingLaundary.Models;
using System.Text.Json;
using System.Text.Json.Serialization;
using WashingLaundary.AutoMapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
        // Add other serialization options if needed
    });

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<CustomerDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("WashingMachineDb")));

//Automapper

builder.Services.AddAutoMapper(typeof(AutoMapperConfigProfile));

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
