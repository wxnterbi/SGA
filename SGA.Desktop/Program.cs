using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SGA.Desktop.Interfaces.Autobus;
using SGA.Desktop.Interfaces.Viaje;
using SGA.Desktop.Modulos.Transporte;
using SGA.Desktop.Modulos.Viaje;
using SGA.Desktop.Services.Autobus;
using System;
using System.IO;
using System.Net.Http;
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
            // Cargar appsettings.json
            var builder = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfiguration configuration = builder.Build();

            // Leer la URL base de SGA.Api ("https://localhost:7218/")
            string baseUrl = configuration["ApiSettings:BaseUrl"] ?? "https://localhost:7218/";

            // =========================================================
            // 1. REGISTRO DE SERVICIOS API (HttpClient)
            // =========================================================
            services.AddHttpClient<IAutobusApiService, AutobusApiService>(client =>
            {
                client.BaseAddress = new Uri(baseUrl);
            });
            services.AddHttpClient<IAutobusApiService, AutobusApiService>(client =>
            {
                client.BaseAddress = new Uri(baseUrl);
            });
            services.AddHttpClient<IViajeApiService, ViajeApiService>(client =>
            {
                client.BaseAddress = new Uri(baseUrl);
            });

            // Nota: Conforme migres cada módulo, agregarás sus clientes API aquí:
            // services.AddHttpClient<IRutaApiService, RutaApiService>(c => c.BaseAddress = new Uri(baseUrl));
            // services.AddHttpClient<IAutobusApiService, AutobusApiService>(c => c.BaseAddress = new Uri(baseUrl));


            // =========================================================
            // 2. REGISTRO DE FORMULARIOS (UI)
            // =========================================================
            services.AddTransient<FrmGestionTransporte>();
            services.AddTransient<FrmNuevoAutobusModal>();
            services.AddTransient<FrmViajePrincipal>();
            services.AddTransient<FrmNuevoViajeModal>();
            services.AddTransient<FrmMainDashboard>();
            services.AddTransient<SGA.Desktop.Modulos.Transporte.FrmGestionTransporte>();
            services.AddTransient<SGA.Desktop.Modulos.Usuario.FrmGestionUsuario>();
            services.AddTransient<SGA.Desktop.Modulos.Usuario.FrmDetalleUsuario>();
        }
    }
}