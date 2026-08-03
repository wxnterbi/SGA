using SGA.Application.Interfaces;
using SGA.Application.Services;
using SGA.Desktop.Services;
using System;
using System.Windows.Forms;

namespace SGA.Desktop
{
    public partial class FrmLogin : Form
    {

        // Constructor sin parámetros (el que llama tu Program.cs)
        public FrmLogin()
        {
            InitializeComponent();
        }

        // Evento del botón Ingresar
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

                    IViajeService viajeService = new ViajeApiService();
                    // Le pasamos los servicios al Dashboard
                    using (FrmMainDashboard dashboard = new FrmMainDashboard(viajeService, null!, null!, null!, null!))
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

        // Evento del botón Cancelar / Salir
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        // Método temporal para probar el flujo sin la API conectada aún
        private bool SimularLlamadaApi(string identificador, string password)
        {
            if (identificador == "admin" && password == "1234")
            {
                return true;
            }
            return false;
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}