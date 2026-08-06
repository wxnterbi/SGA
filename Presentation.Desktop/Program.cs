using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SGA.Presentation.Desktop.Forms;
using SGA.Presentation.Desktop.Forms.Autobus;
using SGA.Presentation.Desktop.Forms.Login;
using SGA.Presentation.Desktop.Forms.Main;
using SGA.Presentation.Desktop.Forms.Viaje;
using SGA.Presentation.Desktop.Interfaces;
using SGA.Presentation.Desktop.Services.Autobus;
using SGA.Presentation.Desktop.Services.Conductor;
using SGA.Presentation.Desktop.Services.Horario;
using SGA.Presentation.Desktop.Services.Ruta;
using SGA.Presentation.Desktop.Services.Viaje;
using System;
using System.Windows.Forms;
using System.Windows.Forms;

namespace SGA.Presentation.Desktop
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; } = null!;

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();

            ConfigureServices(services);

            ServiceProvider = services.BuildServiceProvider();

            System.Windows.Forms.Application.Run(ServiceProvider.GetRequiredService<FrmLogin>());
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            //---------------------------------------------------------
            // Configuración
            //---------------------------------------------------------

            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            services.AddSingleton(configuration);

            string baseUrl = configuration["ApiSettings:BaseUrl"]!;

            //---------------------------------------------------------
            // HttpClient
            //---------------------------------------------------------

            services.AddHttpClient();

            //---------------------------------------------------------
            // API SERVICES
            //---------------------------------------------------------
            services.AddTransient<FrmPrincipal>();
            services.AddTransient<FrmLogin>();
            services.AddTransient<FrmAutobusPrincipal>();
            services.AddTransient<FrmNuevoAutobus>();
            services.AddTransient<FrmDetalleAutobus>();

            #region Viajes

            services.AddHttpClient<IViajeApiService, ViajeApiService>(client =>
            {
                client.BaseAddress = new Uri(baseUrl);
            });

            #endregion

            #region Autobuses

            services.AddHttpClient<IAutobusApiService, AutobusApiService>(client =>
            {
                client.BaseAddress = new Uri(baseUrl);
            });

            #endregion

            #region Usuarios

            //services.AddHttpClient<IUsuarioApiService, UsuarioApiService>(client =>
            //{
            //    client.BaseAddress = new Uri(baseUrl);
            //});

            #endregion

            #region Conductores

            services.AddHttpClient<IConductorApiService, ConductorApiService>(client =>
            {
                client.BaseAddress = new Uri(baseUrl);
            });

            #endregion

            #region Horarios

            services.AddHttpClient<IHorarioApiService, HorarioApiService>(client =>
            {
                client.BaseAddress = new Uri(baseUrl);
            });

            #endregion

            #region Rutas
               
            services.AddHttpClient<IRutaApiService, RutaApiService>(client =>
            {
                client.BaseAddress = new Uri(baseUrl);
            });

            #endregion

            #region Paradas

            //services.AddHttpClient<IParadaApiService, ParadaApiService>(client =>
            //{
            //    client.BaseAddress = new Uri(baseUrl);
            //});

            #endregion

            #region Incidencias

            //services.AddHttpClient<IIncidenciaApiService, IncidenciaApiService>(client =>
            //{
            //    client.BaseAddress = new Uri(baseUrl);
            //});

            #endregion

            //---------------------------------------------------------
            // FORMS
            //---------------------------------------------------------

            #region Login

            services.AddTransient<FrmLogin>();

            #endregion

            #region Dashboard

            //services.AddTransient<FrmDashboard>();

            #endregion

            #region Viajes

            services.AddTransient<FrmViajePrincipal>();
            services.AddTransient<FrmNuevoViaje>();

            #endregion

            #region Autobuses

            //services.AddTransient<FrmAutobusPrincipal>();
            //services.AddTransient<FrmNuevoAutobus>();

            #endregion

            #region Usuarios

            //services.AddTransient<FrmUsuarioPrincipal>();
            //services.AddTransient<FrmNuevoUsuario>();

            #endregion

            #region Conductores

            //services.AddTransient<FrmConductorPrincipal>();

            #endregion

            #region Horarios

            //services.AddTransient<FrmHorarioPrincipal>();

            #endregion

            #region Rutas

            //services.AddTransient<FrmRutaPrincipal>();

            #endregion

            #region Paradas

            //services.AddTransient<FrmParadaPrincipal>();

            #endregion

            #region Incidencias

            //services.AddTransient<FrmIncidenciaPrincipal>();

            #endregion
        }
    }
}