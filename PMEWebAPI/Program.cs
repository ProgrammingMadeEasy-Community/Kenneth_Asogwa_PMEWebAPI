
using Microsoft.EntityFrameworkCore;
using PMEWebAPI.Data;
using PMEWebAPI.Data.Core;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

//Configure the DbContext
builder.Services.AddDbContext<ApplicationDbContext>(options => 
          options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<EmployeeRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
