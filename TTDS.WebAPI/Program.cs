using Microsoft.Extensions.DependencyInjection;
using TTDS.WebAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddTransient<ICalculationService, CalculationService>();

var app = builder.Build();

app.UseAuthorization();

app.MapControllers();

app.Run();
