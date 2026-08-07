using Microsoft.Extensions.DependencyInjection;
using SGA.Presentation.Desktop.Forms.Autobus;
using SGA.Presentation.Desktop.Forms.Conductor;
using SGA.Presentation.Desktop.Forms.DashBoard;
using SGA.Presentation.Desktop.Forms.Horario;
using SGA.Presentation.Desktop.Forms.Parada;
using SGA.Presentation.Desktop.Forms.Ruta;
using SGA.Presentation.Desktop.Forms.Viaje;
using SGA.Presentation.Desktop.Forms.Usuario;
using SGA.Presentation.Desktop.Forms.Incidencia;
using SGA.Presentation.Desktop.Forms.RegistroAcceso;
using SGA.Presentation.Desktop.Forms.TarjetaRecargable;

using System;
using System.Drawing;
using System.Windows.Forms;

namespace SGA.Presentation.Desktop.Forms.Main
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();

            ConfigurarFormulario();

            CargarDashboard();
        }


        private void ConfigurarFormulario()
        {
            lblUsuario.Text = "Usuario: Admin";
            lblRol.Text = "Administrador";


            ConfigurarBoton(btnDashboard, "Dashboard", 180);
            ConfigurarBoton(btnViajes, "Viajes", 230);
            ConfigurarBoton(btnAutobuses, "Autobuses", 280);
            ConfigurarBoton(btnConductores, "Conductores", 330);
            ConfigurarBoton(btnRutas, "Rutas", 380);
            ConfigurarBoton(btnHorarios, "Horarios", 430);
            ConfigurarBoton(btnParadas, "Paradas", 480);
            ConfigurarBoton(btnUsuarios, "Usuarios", 530);
            ConfigurarBoton(btnRegistroAcceso, "Registro Acceso", 580);
            ConfigurarBoton(btnRecargarSaldo, "Recargar Saldo", 630);
            ConfigurarBoton(btnIncidencias, "Incidencias", 680);
            ConfigurarBoton(btnAuditoria, "Auditoria", 730);
            ConfigurarBoton(btnCerrarSesion, "Cerrar Sesión", 800);


            btnViajes.Click += btnViajes_Click;
            btnAutobuses.Click += btnAutobuses_Click;
            btnConductores.Click += btnConductores_Click;
            btnIncidencias.Click += btnIncidencias_Click;

            btnRutas.Click += btnRutas_Click;
            btnHorarios.Click += btnHorarios_Click;
            btnParadas.Click += btnParadas_Click;
            btnUsuarios.Click += btnUsuarios_Click;
            btnRegistroAcceso.Click += btnRegistroAcceso_Click;
            btnRecargarSaldo.Click += btnRecargarSaldo_Click;
            btnDashboard.Click += btnDashboard_Click;

            btnCerrarSesion.Click += btnCerrarSesion_Click;
        }



        private void CargarDashboard()
        {
            pnlContent.Controls.Clear();


            FrmDashboard dashboard = new FrmDashboard();

            dashboard.Dock = DockStyle.Fill;


            pnlContent.Controls.Add(dashboard);
        }

        private void CargarVista(Control vista)
        {
            pnlContent.Controls.Clear();

            vista.Dock = DockStyle.Fill;

            pnlContent.Controls.Add(vista);
        }
        private void ConfigurarBoton(Button boton, string texto, int posicion)
        {
            boton.Text = texto;

            boton.Width = 250;
            boton.Height = 45;

            boton.Left = 0;
            boton.Top = posicion;

            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;

            boton.BackColor = Color.FromArgb(25, 42, 86);

            boton.ForeColor = Color.White;

            boton.Font = new Font(
                "Segoe UI",
                10,
                FontStyle.Regular
            );

            boton.TextAlign = ContentAlignment.MiddleLeft;

            boton.Padding = new Padding(25, 0, 0, 0);

            boton.Cursor = Cursors.Hand;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            CargarDashboard();
        }
        private void btnUsuarios_Click(
            object sender,
            EventArgs e)
        {
            var formulario =
                Program.ServiceProvider
                .GetRequiredService<FrmUsuarioPrincipal>();


            formulario.ShowDialog();
        }

        private void btnRegistroAcceso_Click(object sender, EventArgs e)
        {
            var formulario =
                Program.ServiceProvider
                .GetRequiredService<FrmRegistroAccesoPrincipal>();

            formulario.ShowDialog();
        }

        private void btnRecargarSaldo_Click(object sender, EventArgs e)
        {
            var formulario =
                Program.ServiceProvider
                .GetRequiredService<FrmRecargarSaldoPrincipal>();
            formulario.ShowDialog();
        }
        private void btnAutobuses_Click(object sender, EventArgs e)
        {
            var formulario =
                Program.ServiceProvider
                .GetRequiredService<FrmAutobusPrincipal>();

            formulario.ShowDialog();
        }

        private void btnConductores_Click(object sender, EventArgs e)
        {
            var formulario =
                Program.ServiceProvider
                .GetRequiredService<FrmConductorPrincipal>();

            formulario.ShowDialog();
        }
        private void btnIncidencias_Click(object sender, EventArgs e)
        {
            var formulario =
                Program.ServiceProvider
                .GetRequiredService<FrmIncidenciaPrincipal>();

            formulario.ShowDialog();
        }
        private void btnViajes_Click(object sender, EventArgs e)
        {
            var formulario =
                Program.ServiceProvider
                .GetRequiredService<FrmViajePrincipal>();

            formulario.ShowDialog();
        }

        private void btnRutas_Click(object sender, EventArgs e)
        {
            var formulario =
                Program.ServiceProvider
                .GetRequiredService<FrmRutaPrincipal>();

            formulario.ShowDialog();
        }


        private void btnHorarios_Click(object sender, EventArgs e)
        {
            var formulario =
                Program.ServiceProvider
                .GetRequiredService<FrmHorarioPrincipal>();

            formulario.ShowDialog();
        }


        private void btnParadas_Click(object sender, EventArgs e)
        {
            var formulario =
                Program.ServiceProvider
                .GetRequiredService<FrmParadaPrincipal>();

            formulario.ShowDialog();
        }
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Restart();
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}