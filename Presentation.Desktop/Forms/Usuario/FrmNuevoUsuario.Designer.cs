namespace SGA.Presentation.Desktop.Forms.Usuario
{
    partial class FrmNuevoUsuario
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;

        private Label lblIdentificador;
        private Label lblNombre;
        private Label lblContrasena;
        private Label lblTipoUsuario;
        private Label lblEstado;

        private TextBox txtIdentificador;
        private TextBox txtNombre;
        private TextBox txtContrasena;

        private ComboBox cmbTipoUsuario;
        private ComboBox cmbEstado;

        private Label lblMensajeContrasena;

        private Button btnGuardar;
        private Button btnCancelar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblIdentificador = new Label();
            lblNombre = new Label();
            lblContrasena = new Label();
            lblTipoUsuario = new Label();
            lblEstado = new Label();
            txtIdentificador = new TextBox();
            txtNombre = new TextBox();
            txtContrasena = new TextBox();
            cmbTipoUsuario = new ComboBox();
            cmbEstado = new ComboBox();
            lblMensajeContrasena = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(40, 40, 40);
            lblTitulo.Location = new Point(45, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(209, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "NUEVO USUARIO";
            // 
            // lblIdentificador
            // 
            lblIdentificador.AutoSize = true;
            lblIdentificador.Location = new Point(40, 90);
            lblIdentificador.Name = "lblIdentificador";
            lblIdentificador.Size = new Size(162, 19);
            lblIdentificador.TabIndex = 1;
            lblIdentificador.Text = "Identificador institucional";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(40, 160);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(59, 19);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Location = new Point(40, 230);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(79, 19);
            lblContrasena.TabIndex = 3;
            lblContrasena.Text = "Contraseña";
            // 
            // lblTipoUsuario
            // 
            lblTipoUsuario.AutoSize = true;
            lblTipoUsuario.Location = new Point(40, 320);
            lblTipoUsuario.Name = "lblTipoUsuario";
            lblTipoUsuario.Size = new Size(103, 19);
            lblTipoUsuario.TabIndex = 5;
            lblTipoUsuario.Text = "Tipo de usuario";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(250, 320);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(50, 19);
            lblEstado.TabIndex = 6;
            lblEstado.Text = "Estado";
            // 
            // txtIdentificador
            // 
            txtIdentificador.Location = new Point(40, 115);
            txtIdentificador.Name = "txtIdentificador";
            txtIdentificador.Size = new Size(400, 25);
            txtIdentificador.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(40, 185);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(400, 25);
            txtNombre.TabIndex = 2;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(40, 255);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(400, 25);
            txtContrasena.TabIndex = 3;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // cmbTipoUsuario
            // 
            cmbTipoUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoUsuario.Location = new Point(40, 345);
            cmbTipoUsuario.Name = "cmbTipoUsuario";
            cmbTipoUsuario.Size = new Size(190, 25);
            cmbTipoUsuario.TabIndex = 4;
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.Location = new Point(250, 345);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(190, 25);
            cmbEstado.TabIndex = 5;
            // 
            // lblMensajeContrasena
            // 
            lblMensajeContrasena.AutoSize = true;
            lblMensajeContrasena.Font = new Font("Segoe UI", 9F);
            lblMensajeContrasena.ForeColor = Color.DimGray;
            lblMensajeContrasena.Location = new Point(40, 285);
            lblMensajeContrasena.Name = "lblMensajeContrasena";
            lblMensajeContrasena.Size = new Size(244, 15);
            lblMensajeContrasena.TabIndex = 4;
            lblMensajeContrasena.Text = "Deje vacío si no desea cambiar la contraseña.";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(40, 167, 69);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(80, 405);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(140, 42);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Firebrick;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(260, 405);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(140, 42);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // FrmNuevoUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(480, 490);
            Controls.Add(lblTitulo);
            Controls.Add(lblIdentificador);
            Controls.Add(txtIdentificador);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblContrasena);
            Controls.Add(txtContrasena);
            Controls.Add(lblMensajeContrasena);
            Controls.Add(lblTipoUsuario);
            Controls.Add(cmbTipoUsuario);
            Controls.Add(lblEstado);
            Controls.Add(cmbEstado);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Font = new Font("Segoe UI", 10F);
            Name = "FrmNuevoUsuario";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Usuario";
            Load += FrmNuevoUsuario_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}