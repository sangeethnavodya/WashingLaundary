using Microsoft.EntityFrameworkCore;
using WashingLaundary.Data;
using WashingLaundary.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddDbContext<CustomerDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("WashingMachineDb")));


var app = builder.Build();


app.Run();
