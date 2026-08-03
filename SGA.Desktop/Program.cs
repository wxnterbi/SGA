using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SGA.Application.BusinessRules;
using SGA.Application.Interfaces;
using SGA.Application.Services;
using SGA.Desktop.Modulos.Viaje;
using SGA.Infrastructure.Notifications; // Importante para EmailNotificationService
using SGA.Persistence.Context;
using SGA.Persistence.Interfaces;
using SGA.Persistence.Repositories;
using SGA.Persistence.Repository;
using System;
using System.Windows.Forms;

namespace SGA.Desktop
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // 1. Configurar el contenedor de dependencias
            var services = new ServiceCollection();
            ConfigureServices(services);

            // 2. Construir el proveedor
            ServiceProvider = services.BuildServiceProvider();

            // 3. Iniciar la aplicación
            System.Windows.Forms.Application.Run(new FrmLogin());
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfiguration configuration = builder.Build();

            // 1. REGLAS DE NEGOCIO (Transient)
            services.AddTransient<ViajeRules>();
            services.AddTransient<NotificacionRules>();

            // 2. SERVICIOS DE NOTIFICACIÓN
            // A) Interfaz de Application -> NotificacionService
            services.AddTransient<SGA.Application.Interfaces.INotificacionService, SGA.Application.Services.NotificacionService>();

            // B) Interfaz de Infrastructure -> EmailNotificationService (¡La clase real de tu proyecto!)
            services.AddTransient<SGA.Infrastructure.Notifications.INotificationService, EmailNotificationService>();

            // 3. DBCONTEXT
            services.AddDbContext<SGABD>(options =>
                options.UseSqlServer("Server=.\\SQLEXPRESS;Database=SGABD;Trusted_Connection=True;TrustServerCertificate=True;",
                sqlOptions => sqlOptions.EnableRetryOnFailure()),
                ServiceLifetime.Transient);

            // 4. REPOSITORIOS (Transient)
            services.AddTransient<IRutaRepository, RutaRepository>();
            services.AddTransient<IAutobusRepository, AutobusRepository>();
            services.AddTransient<IConductorRepository, ConductorRepository>();
            services.AddTransient<IHorarioRepository, HorarioRepository>();
            services.AddTransient<IViajeRepository, ViajeRepository>();
            services.AddTransient<INotificacionRepository, NotificacionRepository>();

            // 5. SERVICIOS DE APLICACIÓN (Transient)
            services.AddTransient<IViajeService, ViajeService>();
            services.AddTransient<IRutaService, RutaService>();
            services.AddTransient<IAutobusService, AutobusService>();
            services.AddTransient<IConductorService, ConductorService>();
            services.AddTransient<IHorarioService, HorarioService>();

            // 6. FORMULARIOS (Transient)
            services.AddTransient<FrmViajePrincipal>();
            services.AddTransient<FrmNuevoViajeModal>();
        }
    }
}