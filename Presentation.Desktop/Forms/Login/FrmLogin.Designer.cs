namespace SGA.Presentation.Desktop.Forms.Login
{
    partial class FrmLogin
    {
        private System.ComponentModel.IContainer? components = null;

        private Panel pnlPrincipal;
        private Panel pnlLogin;

        private Label lblTitulo;
        private Label lblUsuario;
        private Label lblPassword;

        private TextBox txtUsuario;
        private TextBox txtPassword;

        private Button btnIngresar;
        private Button btnSalir;

        private PictureBox picLogo;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }


        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.pnlPrincipal = new Panel();
            this.pnlLogin = new Panel();

            this.lblTitulo = new Label();
            this.lblUsuario = new Label();
            this.lblPassword = new Label();

            this.txtUsuario = new TextBox();
            this.txtPassword = new TextBox();

            this.btnIngresar = new Button();
            this.btnSalir = new Button();

            this.picLogo = new PictureBox();


            this.SuspendLayout();


            // 
            // FrmLogin
            //

            this.ClientSize = new Size(900, 600);

            this.StartPosition =
                FormStartPosition.CenterScreen;

            this.Text =
                "SGA - Inicio de Sesión";

            this.FormBorderStyle =
                FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;



            //
            // pnlPrincipal
            //

            pnlPrincipal.Dock =
                DockStyle.Fill;

            pnlPrincipal.BackColor =
                Color.FromArgb(25, 42, 86);



            //
            // pnlLogin
            //

            pnlLogin.Size =
                new Size(400, 450);

            pnlLogin.Location =
                new Point(250, 75);

            pnlLogin.BackColor =
                Color.White;



            //
            // picLogo
            //

            picLogo.Size =
                new Size(90, 90);

            picLogo.Location =
                new Point(155, 30);

            picLogo.SizeMode =
                PictureBoxSizeMode.Zoom;



            //
            // lblTitulo
            //

            lblTitulo.Text =
                "Sistema de Gestión de Autobuses";

            lblTitulo.Font =
                new Font(
                    "Segoe UI",
                    16,
                    FontStyle.Bold);

            lblTitulo.AutoSize =
                true;

            lblTitulo.ForeColor =
                Color.FromArgb(25, 42, 86);

            lblTitulo.Location =
                new Point(45, 140);



            //
            // lblUsuario
            //

            lblUsuario.Text =
                "Usuario";

            lblUsuario.Location =
                new Point(50, 210);

            lblUsuario.AutoSize =
                true;



            //
            // txtUsuario
            //

            txtUsuario.Location =
                new Point(50, 235);

            txtUsuario.Size =
                new Size(300, 30);



            //
            // lblPassword
            //

            lblPassword.Text =
                "Contraseña";

            lblPassword.Location =
                new Point(50, 280);

            lblPassword.AutoSize =
                true;



            //
            // txtPassword
            //

            txtPassword.Location =
                new Point(50, 305);

            txtPassword.Size =
                new Size(300, 30);

            txtPassword.PasswordChar =
                '*';



            //
            // btnIngresar
            //

            btnIngresar.Text =
                "Ingresar";

            btnIngresar.Size =
                new Size(140, 40);

            btnIngresar.Location =
                new Point(50, 370);

            btnIngresar.BackColor =
                Color.FromArgb(25, 42, 86);

            btnIngresar.ForeColor =
                Color.White;

            btnIngresar.FlatStyle =
                FlatStyle.Flat;



            //
            // btnSalir
            //

            btnSalir.Text =
                "Salir";

            btnSalir.Size =
                new Size(140, 40);

            btnSalir.Location =
                new Point(210, 370);

            btnSalir.FlatStyle =
                FlatStyle.Flat;



            //
            // agregar controles
            //

            pnlLogin.Controls.Add(picLogo);
            pnlLogin.Controls.Add(lblTitulo);

            pnlLogin.Controls.Add(lblUsuario);
            pnlLogin.Controls.Add(txtUsuario);

            pnlLogin.Controls.Add(lblPassword);
            pnlLogin.Controls.Add(txtPassword);

            pnlLogin.Controls.Add(btnIngresar);
            pnlLogin.Controls.Add(btnSalir);


            pnlPrincipal.Controls.Add(pnlLogin);


            this.Controls.Add(pnlPrincipal);


            this.ResumeLayout(false);
        }
    }
}