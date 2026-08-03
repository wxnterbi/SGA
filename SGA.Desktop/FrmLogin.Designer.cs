namespace SGA.Desktop
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            pictureBox1 = new PictureBox();
            lblTitulo = new Label();
            lblUsuario = new Label();
            lblPassword = new Label();
            txtIdentificador = new TextBox();
            txtPassword = new TextBox();
            btnIngresar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(70, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(236, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(0, 40, 85);
            lblTitulo.Location = new Point(12, 110);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(360, 32);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Sistema de Gestión de Autobuses";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = Color.FromArgb(15, 23, 42);
            lblUsuario.Location = new Point(32, 185);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(165, 17);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Identificador Institucional:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.FromArgb(15, 23, 42);
            lblPassword.Location = new Point(32, 248);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(80, 17);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Contraseña:";
            // 
            // txtIdentificador
            // 
            txtIdentificador.BorderStyle = BorderStyle.FixedSingle;
            txtIdentificador.Font = new Font("Segoe UI", 10.5F);
            txtIdentificador.ForeColor = Color.FromArgb(15, 23, 42);
            txtIdentificador.Location = new Point(32, 207);
            txtIdentificador.Name = "txtIdentificador";
            txtIdentificador.Size = new Size(320, 26);
            txtIdentificador.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 10.5F);
            txtPassword.ForeColor = Color.FromArgb(15, 23, 42);
            txtPassword.Location = new Point(32, 270);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(320, 26);
            txtPassword.TabIndex = 6;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(0, 86, 179);
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(32, 325);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(320, 42);
            btnIngresar.TabIndex = 7;
            btnIngresar.Text = "Iniciar Sesión";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(226, 232, 240);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.FromArgb(51, 65, 85);
            btnCancelar.Location = new Point(32, 377);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(320, 36);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Salir";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(384, 445);
            Controls.Add(btnCancelar);
            Controls.Add(btnIngresar);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtIdentificador);
            Controls.Add(lblUsuario);
            Controls.Add(lblTitulo);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Acceso al Sistema - SGA ITLA";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblTitulo;
        private Label lblUsuario;
        private Label lblPassword;
        private TextBox txtIdentificador;
        private TextBox txtPassword;
        private Button btnIngresar;
        private Button btnCancelar;
    }
}