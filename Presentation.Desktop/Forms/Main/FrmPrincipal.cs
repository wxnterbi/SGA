using System;
using System.Drawing;
using System.Windows.Forms;

using Microsoft.Extensions.DependencyInjection;
using SGA.Presentation.Desktop.Forms.Autobus;
using SGA.Presentation.Desktop.Forms.DashBoard;
using SGA.Presentation.Desktop.Forms.Viaje;

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
            ConfigurarBoton(btnIncidencias, "Incidencias", 580);
            ConfigurarBoton(btnAuditoria, "Auditoria", 630);
            ConfigurarBoton(btnCerrarSesion, "Cerrar Sesión", 700);


            btnViajes.Click += btnViajes_Click;
            btnAutobuses.Click += btnAutobuses_Click;

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
        private void btnAutobuses_Click(object sender, EventArgs e)
        {
            var formulario =
                Program.ServiceProvider
                .GetRequiredService<FrmAutobusPrincipal>();

            formulario.ShowDialog();
        }
        private void btnViajes_Click(object sender, EventArgs e)
        {
            var formulario =
                Program.ServiceProvider
                .GetRequiredService<FrmViajePrincipal>();

            formulario.ShowDialog();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Restart();
        }

    }
}