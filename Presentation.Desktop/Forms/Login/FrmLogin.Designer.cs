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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            pnlPrincipal = new Panel();
            pnlLogin = new Panel();
            picLogo = new PictureBox();
            lblTitulo = new Label();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnIngresar = new Button();
            btnSalir = new Button();
            pnlPrincipal.SuspendLayout();
            pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.BackColor = Color.FromArgb(25, 42, 86);
            pnlPrincipal.Controls.Add(pnlLogin);
            pnlPrincipal.Dock = DockStyle.Fill;
            pnlPrincipal.Location = new Point(0, 0);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(900, 600);
            pnlPrincipal.TabIndex = 0;
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = Color.White;
            pnlLogin.Controls.Add(picLogo);
            pnlLogin.Controls.Add(lblTitulo);
            pnlLogin.Controls.Add(lblUsuario);
            pnlLogin.Controls.Add(txtUsuario);
            pnlLogin.Controls.Add(lblPassword);
            pnlLogin.Controls.Add(txtPassword);
            pnlLogin.Controls.Add(btnIngresar);
            pnlLogin.Controls.Add(btnSalir);
            pnlLogin.Location = new Point(250, 75);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(400, 450);
            pnlLogin.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(84, 46);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(241, 93);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(25, 42, 86);
            lblTitulo.Location = new Point(19, 142);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(358, 30);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Sistema de Gestión de Autobuses";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(50, 210);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(57, 15);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Matricula";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(50, 235);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(300, 23);
            txtUsuario.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(50, 280);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(67, 15);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Contraseña";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(50, 305);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(300, 23);
            txtPassword.TabIndex = 5;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(25, 42, 86);
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(50, 370);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(140, 40);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Location = new Point(210, 370);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(140, 40);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            // 
            // FrmLogin
            // 
            ClientSize = new Size(900, 600);
            Controls.Add(pnlPrincipal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SGA - Inicio de Sesión";
            pnlPrincipal.ResumeLayout(false);
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }
    }
}