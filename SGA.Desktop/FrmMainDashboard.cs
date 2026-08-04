using Microsoft.Extensions.DependencyInjection;
using SGA.Desktop.Interfaces.Autobus;
using SGA.Desktop.Interfaces.Viaje;
using SGA.Desktop.Modulos.Reporte;
using SGA.Desktop.Modulos.RutaHorarios;
using SGA.Desktop.Modulos.Transporte;
using SGA.Desktop.Modulos.Usuario;
using SGA.Desktop.Modulos.Viaje;
using System;
using System.Windows.Forms;

namespace SGA.Desktop
{
    public partial class FrmMainDashboard : Form
    {
        private Form? formularioActivo = null;

        // Constructor vacio que resuelve los modulos desde el ServiceProvider
        public FrmMainDashboard()
        {
            InitializeComponent();
        }

        private void FrmMainDashboard_Load(object sender, EventArgs e)
        {
            CargarModuloViajes();
        }

        private void CargarModuloViajes()
        {
            try
            {
                var frmViajes = Program.ServiceProvider.GetRequiredService<FrmViajePrincipal>();
                AbrirFormularioHijo(frmViajes, "Control de Viajes");
            }
            catch
            {
                // 🟢 Resolver el servicio de la API antes de crear el formulario manualmente
                var viajeApiService = Program.ServiceProvider.GetRequiredService<IViajeApiService>();
                AbrirFormularioHijo(new FrmViajePrincipal(viajeApiService), "Control de Viajes");
            }
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

            pnlContenedor.Controls.Clear();
            pnlContenedor.Controls.Add(formularioHijo);
            pnlContenedor.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }

        private void btnViajes_Click(object sender, EventArgs e)
        {
            CargarModuloViajes();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            try
            {
                var frmUsuarios = Program.ServiceProvider.GetRequiredService<FrmGestionUsuario>();
                AbrirFormularioHijo(frmUsuarios, "Gestión de Usuarios");
            }
            catch
            {
                AbrirFormularioHijo(new FrmGestionUsuario(), "Gestión de Usuarios");
            }
        }

        private void btnTransporte_Click(object sender, EventArgs e)
        {
            try
            {
                var frmTransporte = Program.ServiceProvider.GetRequiredService<FrmGestionTransporte>();
                AbrirFormularioHijo(frmTransporte, "Gestión de Transporte");
            }
            catch
            {
                AbrirFormularioHijo(new FrmGestionTransporte(), "Gestión de Transporte");
            }
        }

        private void btnRutaHorarios_Click(object sender, EventArgs e)
        {
            try
            {
                var frmRutas = Program.ServiceProvider.GetRequiredService<FrmGestionRutaHorario>();
                AbrirFormularioHijo(frmRutas, "Rutas y Horarios");
            }
            catch
            {
                AbrirFormularioHijo(new FrmGestionRutaHorario(), "Rutas y Horarios");
            }
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            try
            {
                var frmReportes = Program.ServiceProvider.GetRequiredService<FrmReporteAuditoria>();
                AbrirFormularioHijo(frmReportes, "Reportes y Auditoría");
            }
            catch
            {
                AbrirFormularioHijo(new FrmReporteAuditoria(), "Reportes y Auditoría");
            }
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