using SGA.Presentation.Desktop.Common;
using SGA.Presentation.Desktop.Forms.Login;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace SGA.Presentation.Desktop.Forms.Profile
{
    public partial class FrmSeleccionPerfil : Form
    {
        public FrmSeleccionPerfil()
        {
            InitializeComponent();
        }


        private void btnConductor_Click(object sender, EventArgs e)
        {
            AbrirLogin(PerfilAcceso.Conductor);
        }


        private void btnAdministradorTransporte_Click(object sender, EventArgs e)
        {
            AbrirLogin(PerfilAcceso.AdministradorTransporte);
        }


        private void btnAdministradorAutorizaciones_Click(object sender, EventArgs e)
        {
            AbrirLogin(PerfilAcceso.AdministradorAutorizaciones);
        }


        private void btnAuditor_Click(object sender, EventArgs e)
        {
            AbrirLogin(PerfilAcceso.Auditor);
        }


        private void AbrirLogin(PerfilAcceso perfil)
        {
            var login =
                ActivatorUtilities.CreateInstance<FrmLogin>(
                    Program.ServiceProvider,
                    perfil);

            Hide();

            login.ShowDialog();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}