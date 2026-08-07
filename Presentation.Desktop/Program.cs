using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SGA.Presentation.Desktop.Services.Usuario;
using SGA.Presentation.Desktop.Forms.Usuario;
using SGA.Presentation.Desktop.Services.Incidencia;
using SGA.Presentation.Desktop.Forms.Incidencia;
using SGA.Presentation.Desktop.Services.Autobus;
using SGA.Presentation.Desktop.Services.Conductor;
using SGA.Presentation.Desktop.Services.Horario;
using SGA.Presentation.Desktop.Services.Parada;
using SGA.Presentation.Desktop.Services.Ruta;
using SGA.Presentation.Desktop.Services.Viaje;
using SGA.Presentation.Desktop.Interfaces;
using SGA.Presentation.Desktop.Forms.Autobus;
using SGA.Presentation.Desktop.Forms.Horario;
using SGA.Presentation.Desktop.Forms.Parada;
using SGA.Presentation.Desktop.Forms.Ruta;
using SGA.Presentation.Desktop.Forms.Login;
using SGA.Presentation.Desktop.Forms.Main;
using SGA.Presentation.Desktop.Forms.Viaje;
using SGA.Presentation.Desktop.Forms.Conductor;
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
            services.AddTransient<FrmUsuarioPrincipal>();
            services.AddTransient<FrmNuevoUsuario>();
            services.AddTransient<FrmDetalleUsuario>();

            #region Registro Acceso

            // services.AddTransient<FrmRegistroAccesoPrincipal>();
            // services.AddTransient<FrmNuevoRegistroAcceso>();
            // services.AddTransient<FrmDetalleRegistroAcceso>();

            #endregion
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

            services.AddHttpClient<IUsuarioApiService, UsuarioApiService>(client =>
            {
                client.BaseAddress = new Uri(baseUrl);
            });

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

            #region Registro Acceso

            // services.AddHttpClient<IRegistroAccesoApiService, RegistroAccesoApiService>(client =>
            // {
            //     client.BaseAddress = new Uri(baseUrl);
            // });

            #endregion

            #region Incidencias

            services.AddHttpClient<IIncidenciaApiService, IncidenciaApiService>(client =>
            {
                client.BaseAddress = new Uri(baseUrl);
            });

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
            services.AddTransient<FrmDetalleViaje>();

            #endregion

            #region Autobuses

            //services.AddTransient<FrmAutobusPrincipal>();
            //services.AddTransient<FrmNuevoAutobus>();

            #endregion

            #region Usuarios

            services.AddTransient<FrmUsuarioPrincipal>();
            services.AddTransient<FrmNuevoUsuario>();
            services.AddTransient<FrmDetalleUsuario>();

            #endregion

            #region Conductores

            services.AddTransient<FrmConductorPrincipal>();
            services.AddTransient<FrmNuevoConductor>();
            services.AddTransient<FrmDetalleConductor>();

            #endregion

            #region Horarios

            services.AddTransient<FrmHorarioPrincipal>();
            services.AddTransient<FrmNuevoHorario>();
            services.AddTransient<FrmDetalleHorario>();
            #endregion

            #region Rutas


            services.AddTransient<FrmRutaPrincipal>();
            services.AddTransient<FrmNuevaRuta>();
            services.AddTransient<FrmDetalleRuta>();
            #endregion

            #region Paradas

            //services.AddTransient<FrmParadaPrincipal>();
            services.AddHttpClient<IParadaApiService, ParadaApiService>(client =>
            {
                client.BaseAddress = new Uri(baseUrl);
            });

            services.AddTransient<FrmParadaPrincipal>();
            services.AddTransient<FrmNuevaParada>();
            services.AddTransient<FrmDetalleParada>();

            #endregion

            #region Incidencias

            services.AddTransient<FrmIncidenciaPrincipal>();
            services.AddTransient<FrmNuevaIncidencia>();
            services.AddTransient<FrmDetalleIncidencia>();

            #endregion
        }
    }
}