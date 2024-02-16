using Microsoft.EntityFrameworkCore;
//using WashingLaundary.Models;
using WashingLaundary.Context;
using System.Text.Json;
using System.Text.Json.Serialization;
using WashingLaundary.AutoMapper;
//using WashingLaundary.AutoMapper;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("WashingMachineDb")));

//Automapper

builder.Services.AddAutoMapper(typeof(AutoMapperConfigProfile));

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
        // Add other serialization options if needed
    });


//builder.Services.AddAutoMapper(typeof(AutoMapperConfigProfile));

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
