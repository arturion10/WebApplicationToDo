using Microsoft.EntityFrameworkCore;
using WebApplicationTest.Models;

var builder = WebApplication.CreateBuilder(args);

string connection = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connection));

builder.Services.AddMvc();

var app = builder.Build();

app.MapDefaultControllerRoute();

app.Run();