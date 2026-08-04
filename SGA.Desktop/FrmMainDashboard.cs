using Microsoft.Extensions.DependencyInjection;
using SGA.Application.Interfaces;
using SGA.Application.Services;
using SGA.Desktop.Modulos.Transporte;
using SGA.Desktop.Modulos.Viaje;
using System;
using System.Reflection;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SGA.Desktop
{
    public partial class FrmMainDashboard : Form
    {
        private Form? formularioActivo = null;
        private readonly IViajeService _viajeService;
        private readonly IRutaService _rutaService;
        private readonly IAutobusService _autobusService;
        private readonly IConductorService _conductorService;
        private readonly IHorarioService _horarioService;

        public FrmMainDashboard(
        IViajeService viajeService,
        IRutaService rutaService,
        IAutobusService autobusService,
        IConductorService conductorService,
        IHorarioService horarioService)
        {
            InitializeComponent();

            // 2. Solo los asignas a los campos privados (sin el 'new')
            _viajeService = viajeService;
            _rutaService = rutaService;
            _autobusService = autobusService;
            _conductorService = conductorService;
            _horarioService = horarioService;

            this.Shown += FrmMainDashboard_Shown;
        }

        private void FrmMainDashboard_Shown(object sender, EventArgs e)
        {
            // Carga la vista una vez que la ventana principal ya está totalmente renderizada
            AbrirFormularioHijo(new Modulos.Viaje.FrmViajePrincipal(
                _viajeService,
                _rutaService,
                _autobusService,
                _conductorService,
                _horarioService
                ), "Control de Viajes");
        }

        // Método genérico para abrir un formulario dentro del pnlContenedor
        private void AbrirFormularioHijo(Form formularioHijo, string tituloSeccion)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

            formularioActivo = formularioHijo;
            lblTituloSeccion.Text = tituloSeccion;

            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;

            pnlContenedor.Controls.Add(formularioHijo);
            pnlContenedor.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }

        private void FrmMainDashboard_Load(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Modulos.Viaje.FrmViajePrincipal(
                _viajeService,
                _rutaService,
                _autobusService,
                _conductorService,
                _horarioService
                ), "Control de Viajes");
        }

        private void btnViajes_Click(object sender, EventArgs e)
        {
            var frmViajes = Program.ServiceProvider.GetRequiredService<Modulos.Viaje.FrmViajePrincipal>();

            // 2. Se la pasamos a tu método para abrir formularios hijos
            AbrirFormularioHijo(frmViajes, "Control de Viajes");
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Modulos.Usuario.FrmGestionUsuario(), "Gestión de Usuarios");
        }

        private void btnTransporte_Click(object sender, EventArgs e)
        {
            var frmTransporte = Program.ServiceProvider.GetRequiredService<SGA.Desktop.Modulos.Transporte.FrmGestionTransporte>();
            AbrirFormularioHijo(frmTransporte, "Gestión de Transporte");
        }

        private void btnRutaHorarios_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Modulos.RutaHorarios.FrmGestionRutaHorario(), "Rutas y Horarios");
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Modulos.Reporte.FrmReporteAuditoria(), "Reportes y Auditoría");
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            var confirmacion = MessageBox.Show(
                "¿Está seguro de que desea cerrar sesión?",
                "Cerrar Sesión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.OK; 
                this.Close(); 
            }
        }
    }
}