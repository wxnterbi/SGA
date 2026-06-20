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

builder.Services.AddDbContext<SGABD>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<IAutobusRepository, AutobusRepository>();
builder.Services.AddScoped<IConductorRepository, ConductorRepository>();
builder.Services.AddScoped<IRutaRepository, RutaRepository>();
builder.Services.AddScoped<IParadaRepository, ParadaRepository>();
builder.Services.AddScoped<IHorarioRepository, HorarioRepository>();

builder.Services.AddScoped<IAuditoriaRepository, AuditoriaRepository>();
builder.Services.AddScoped<IIncidenciaRepository, IncidenciaRepository>();
builder.Services.AddScoped<INotificacionRepository, NotificacionRepository>();
builder.Services.AddScoped<IPagoRepository, PagoRepository>();
builder.Services.AddScoped<IRegistroAccesoRepository, RegistroAccesoRepository>();
builder.Services.AddScoped<ITarjetaRecargableRepository, TarjetaRecargableRepository>();
builder.Services.AddScoped<ITicketMensualRepository, TicketMensualRepository>();
builder.Services.AddScoped<IViajeRepository, ViajeRepository>();

builder.Services.AddScoped<UsuarioRules>();
builder.Services.AddScoped<ViajeRules>();
builder.Services.AddScoped<PagoRules>();
builder.Services.AddScoped<AccesoRules>();

builder.Services.AddScoped<INotificationService, EmailNotificationService>();
builder.Services.AddSingleton<ErrorLogger>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();