using FluentValidation;
using FluentValidation.AspNetCore;
using SGA.Application.BusinessRules;
using SGA.Application.Validations;
using SGA.IOC;
using Microsoft.EntityFrameworkCore;
using SGA.Persistence.Context;

var builder = WebApplication.CreateBuilder(args);


// CONTROLLERS


builder.Services.AddControllers();



// FLUENT VALIDATION


builder.Services.AddFluentValidationAutoValidation();

builder.Services.AddValidatorsFromAssemblyContaining<
    Program>();



// SWAGGER


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// CORS


builder.Services.AddCors(options =>
{
    options.AddPolicy("VuePolicy", policy =>
    {
        policy
            .WithOrigins("http://localhost:5173")
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});



// DEPENDENCY INJECTION

builder.Services.AddDbContext<SGABD>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddDependencyInjection();



// HTTP CONTEXT

builder.Services.AddHttpContextAccessor();


var app = builder.Build();


// MIDDLEWARE


app.UseMiddleware<
    SGA.Api.Desktop.Middleware.ExceptionMiddleware>();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseCors("VuePolicy");


app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();