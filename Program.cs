using Shack.Application.UseCasese;
using Shack.Domain.Repository;
using Shack.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// TODO organize DI
builder.Services.AddTransient<IDashboardsRepository, DashboardsRepository>();
builder.Services.AddTransient<GetDashboardByIdUseCase>();
builder.Services.AddTransient<GetAllDashboardsUseCase>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}

app.MapControllers();

app.Run();
