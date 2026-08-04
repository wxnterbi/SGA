using Microsoft.Extensions.DependencyInjection;
using SGA.Desktop.Interfaces.Viaje;
using System;
using System.Windows.Forms;

namespace SGA.Desktop
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string identificador = txtIdentificador.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(identificador) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos Requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool loginExitoso = SimularLlamadaApi(identificador, password);

                if (loginExitoso)
                {
                    this.Hide();

                    // 🟢 Se instancia FrmMainDashboard usando el constructor vacio y el DI Container
                    using (FrmMainDashboard dashboard = Program.ServiceProvider.GetRequiredService<FrmMainDashboard>())
                    {
                        DialogResult resultado = dashboard.ShowDialog();

                        if (resultado == DialogResult.OK)
                        {
                            txtPassword.Clear();
                            txtIdentificador.Clear();
                            txtIdentificador.Focus();

                            this.Show();
                        }
                        else
                        {
                            System.Windows.Forms.Application.Exit();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas o usuario no autorizado.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con el servidor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private bool SimularLlamadaApi(string identificador, string password)
        {
            return identificador == "admin" && password == "1234";
        }

        private void lblTitulo_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
    }
}