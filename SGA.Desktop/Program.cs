using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SGA.Desktop.Interfaces;
using SGA.Desktop.Interfaces.Autobus;
using SGA.Desktop.Interfaces.Viaje;
using SGA.Desktop.Modulos.RutaHorarios;
using SGA.Desktop.Modulos.Transporte;
using SGA.Desktop.Modulos.Usuario;
using SGA.Desktop.Modulos.Viaje;
using SGA.Desktop.Services;
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

            var services = new ServiceCollection();
            ConfigureServices(services);

            ServiceProvider = services.BuildServiceProvider();

            System.Windows.Forms.Application.Run(new FrmLogin());
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfiguration configuration = builder.Build();

            // Garantizar la barra final en la URL base de la API
            string rawUrl = configuration["ApiSettings:BaseUrl"] ?? "https://localhost:7218/";
            if (!rawUrl.EndsWith("/")) rawUrl += "/";
            string baseUrl = $"{rawUrl}api/";

            // =========================================================
            // 1. REGISTRO DE SERVICIOS API (HttpClient)
            // =========================================================
            services.AddHttpClient<IAutobusApiService, AutobusApiService>(client =>
            {
                client.BaseAddress = new Uri(baseUrl);
            });
            services.AddHttpClient<IUsuarioApiService, UsuarioApiService>(client =>
            {
                client.BaseAddress = new Uri(baseUrl);
            });
            services.AddHttpClient<IViajeApiService, ViajeApiService>(client =>
            {
                client.BaseAddress = new Uri(baseUrl);
            });

            // ApiClient Genérico
            services.AddSingleton<ApiClient>();

            // =========================================================
            // 2. REGISTRO DE FORMULARIOS (UI)
            // =========================================================
            services.AddTransient<FrmGestionTransporte>();
            services.AddTransient<FrmNuevoAutobusModal>();
            services.AddTransient<FrmViajePrincipal>();
            services.AddTransient<FrmNuevoViajeModal>();
            services.AddTransient<FrmMainDashboard>();
            services.AddTransient<FrmGestionUsuario>();
            services.AddTransient<FrmAgregarNuevoUsuario>();
            services.AddTransient<FrmRecargarTarjetaModal>();
            services.AddTransient<FrmGestionRutaHorario>();
        }
    }
}