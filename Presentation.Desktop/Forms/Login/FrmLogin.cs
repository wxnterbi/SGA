using Microsoft.Extensions.DependencyInjection;
using SGA.Presentation.Desktop.Common;
using SGA.Presentation.Desktop.Forms.Main;
using SGA.Presentation.Desktop.Forms.Profile;
using SGA.Domain.Enums.Configuration;
using SGA.Presentation.Desktop.Interfaces;
using SGA.Application.Dtos.Usuario;
using System;
using System.Windows.Forms;

namespace SGA.Presentation.Desktop.Forms.Login
{
    public partial class FrmLogin : Form
    {
        private readonly PerfilAcceso _perfilSeleccionado;
        private readonly IUsuarioApiService _usuarioApiService;

        public FrmLogin(
            PerfilAcceso perfil,
            IUsuarioApiService usuarioApiService)
        {
            InitializeComponent();

            _perfilSeleccionado = perfil;
            _usuarioApiService = usuarioApiService;

            btnIngresar.Click += btnIngresar_Click;
            btnSalir.Click += btnSalir_Click;
        }


        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private bool ValidarPerfil(TipoUsuario tipoUsuario)
        {
            return _perfilSeleccionado switch
            {
                PerfilAcceso.Conductor =>
                    tipoUsuario == TipoUsuario.Conductor,

                PerfilAcceso.AdministradorTransporte =>
                    tipoUsuario == TipoUsuario.AdministradorTransporte,

                PerfilAcceso.AdministradorAutorizaciones =>
                    tipoUsuario == TipoUsuario.AdministradorAutorizaciones,

                PerfilAcceso.Auditor =>
                    tipoUsuario == TipoUsuario.Auditor,

                _ => false
            };
        }
        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show(
                    "Debe completar usuario y contraseña",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            var loginDto = new LoginUsuarioDto
            {
                IdentificadorInstitucional = txtUsuario.Text,
                Contrasena = txtPassword.Text
            };


            var usuario =
                await _usuarioApiService.LoginAsync(loginDto);


            if (usuario == null)
            {
                MessageBox.Show(
                    "Usuario o contraseña incorrectos",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }


            if (!ValidarPerfil(usuario.TipoUsuario))
            {
                MessageBox.Show(
                    "El usuario no pertenece al perfil seleccionado",
                    "Acceso denegado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            FrmPrincipal principal =
                new FrmPrincipal(usuario);

            principal.Show();

            this.Close();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
