using SGA.IOC;
using Microsoft.EntityFrameworkCore;
using SGA.Persistence.Context;
using SGA.Persistence.Interfaces;
using SGA.Persistence.Repositories;
using SGA.Persistence.Repository;
using SGA.Application.BusinessRules;
using SGA.Infrastructure.Logging;
using SGA.Infrastructure.Notifications;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("VuePolicy",
        policy =>
        {
            policy.WithOrigins("http://localhost:5173")
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});

builder.Services.AddDbContext<SGABD>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddDependencyInjection();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("VuePolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();