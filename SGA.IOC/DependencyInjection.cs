using Microsoft.Extensions.DependencyInjection;
using SGA.Application.BusinessRules;
using SGA.Application.Interfaces;
using SGA.Application.Services;
using SGA.Infrastructure.Logging;
using SGA.Infrastructure.Notifications;
using SGA.Persistence.Interfaces;
using SGA.Persistence.Repositories;
using SGA.Persistence.Repository;


namespace SGA.IOC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
        {
            // Repositorios
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IAutobusRepository, AutobusRepository>();
            services.AddScoped<IConductorRepository, ConductorRepository>();
            services.AddScoped<IRutaRepository, RutaRepository>();
            services.AddScoped<IParadaRepository, ParadaRepository>();
            services.AddScoped<IHorarioRepository, HorarioRepository>();
            services.AddScoped<IAuditoriaRepository, AuditoriaRepository>();
            services.AddScoped<IIncidenciaRepository, IncidenciaRepository>();
            services.AddScoped<INotificacionRepository, NotificacionRepository>();
            services.AddScoped<IPagoRepository, PagoRepository>();
            services.AddScoped<IRegistroAccesoRepository, RegistroAccesoRepository>();
            services.AddScoped<ITarjetaRecargableRepository, TarjetaRecargableRepository>();
            services.AddScoped<ITicketMensualRepository, TicketMensualRepository>();
            services.AddScoped<IViajeRepository, ViajeRepository>();

            // Services
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<IRutaService, RutaService>();
            services.AddScoped<IHorarioService, HorarioService>();
            services.AddScoped<IParadaService, ParadaService>();
            services.AddScoped<IPagoService, PagoService>();
            services.AddScoped<IAutobusService, AutobusService>();
            services.AddScoped<IConductorService, ConductorService>();
            services.AddScoped<IIncidenciaService, IncidenciaService>();
            services.AddScoped<ITicketMensualService, TicketMensualService>();
            services.AddScoped<ITarjetaRecargableService, TarjetaRecargableService>();
            services.AddScoped<IRegistroAccesoService, RegistroAccesoService>();
            services.AddScoped<INotificacionService, NotificacionService>();
            services.AddScoped<IViajeService, ViajeService>();
            services.AddScoped<IAuditoriaService, AuditoriaService>();
            services.AddScoped<IAuditoriaService, AuditoriaService>();
            services.AddScoped<IAuditoriaRepository, AuditoriaRepository>();

            // Business Rules
            services.AddScoped<UsuarioRules>();
            services.AddScoped<ViajeRules>();
            services.AddScoped<PagoRules>();
            services.AddScoped<AccesoRules>();
            services.AddScoped<NotificacionRules>();
            services.AddScoped<IncidenciaRules>();
            services.AddScoped<AuditoriaRules>();



            // Infrastructure
            services.AddScoped<INotificationService, EmailNotificationService>();
            services.AddSingleton<ErrorLogger>();

            return services;
        }
    }
}
