using System;
using System.Windows.Forms;
using SGA.Presentation.Desktop.Forms.Main;

namespace SGA.Presentation.Desktop.Forms.Login
{
    public partial class FrmLogin : Form
    {

        public FrmLogin()
        {
            InitializeComponent();
            btnIngresar.Click += btnIngresar_Click;

            btnSalir.Click += btnSalir_Click;
        }



        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }



        private void btnIngresar_Click(object sender, EventArgs e)
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



            FrmPrincipal principal =
                new FrmPrincipal();


            principal.Show();


            this.Hide();

        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
    }
}