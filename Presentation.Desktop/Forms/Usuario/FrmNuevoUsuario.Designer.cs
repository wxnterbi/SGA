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

            lblTitulo.Font =
                new Font("Segoe UI", 18F, FontStyle.Bold);

            lblTitulo.ForeColor =
                Color.FromArgb(40, 40, 40);

            lblTitulo.Location =
                new Point(45, 25);

            lblTitulo.Name =
                "lblTitulo";

            lblTitulo.Size =
                new Size(245, 41);

            lblTitulo.TabIndex = 0;

            lblTitulo.Text =
                "NUEVO USUARIO";

            // 
            // lblIdentificador
            // 
            lblIdentificador.AutoSize = true;

            lblIdentificador.Location =
                new Point(40, 90);

            lblIdentificador.Name =
                "lblIdentificador";

            lblIdentificador.Size =
                new Size(185, 20);

            lblIdentificador.Text =
                "Identificador institucional";

            // 
            // txtIdentificador
            // 
            txtIdentificador.Location =
                new Point(40, 115);

            txtIdentificador.Name =
                "txtIdentificador";

            txtIdentificador.Size =
                new Size(400, 27);

            txtIdentificador.TabIndex = 1;

            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;

            lblNombre.Location =
                new Point(40, 160);

            lblNombre.Name =
                "lblNombre";

            lblNombre.Size =
                new Size(64, 20);

            lblNombre.Text =
                "Nombre";

            // 
            // txtNombre
            // 
            txtNombre.Location =
                new Point(40, 185);

            txtNombre.Name =
                "txtNombre";

            txtNombre.Size =
                new Size(400, 27);

            txtNombre.TabIndex = 2;

            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;

            lblContrasena.Location =
                new Point(40, 230);

            lblContrasena.Name =
                "lblContrasena";

            lblContrasena.Size =
                new Size(87, 20);

            lblContrasena.Text =
                "Contraseña";

            // 
            // txtContrasena
            // 
            txtContrasena.Location =
                new Point(40, 255);

            txtContrasena.Name =
                "txtContrasena";

            txtContrasena.Size =
                new Size(400, 27);

            txtContrasena.TabIndex = 3;

            txtContrasena.UseSystemPasswordChar =
                true;

            // 
            // lblMensajeContrasena
            // 
            lblMensajeContrasena.AutoSize = true;

            lblMensajeContrasena.Font =
                new Font("Segoe UI", 9F);

            lblMensajeContrasena.ForeColor =
                Color.Gray;

            lblMensajeContrasena.Location =
                new Point(40, 285);

            lblMensajeContrasena.Name =
                "lblMensajeContrasena";

            lblMensajeContrasena.Size =
                new Size(300, 15);

            lblMensajeContrasena.Text =
                "Deje vacío si no desea cambiar la contraseña.";

            // 
            // lblTipoUsuario
            // 
            lblTipoUsuario.AutoSize = true;

            lblTipoUsuario.Location =
                new Point(40, 320);

            lblTipoUsuario.Name =
                "lblTipoUsuario";

            lblTipoUsuario.Size =
                new Size(110, 20);

            lblTipoUsuario.Text =
                "Tipo de usuario";

            // 
            // cmbTipoUsuario
            // 
            cmbTipoUsuario.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbTipoUsuario.Location =
                new Point(40, 345);

            cmbTipoUsuario.Name =
                "cmbTipoUsuario";

            cmbTipoUsuario.Size =
                new Size(190, 28);

            cmbTipoUsuario.TabIndex = 4;

            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;

            lblEstado.Location =
                new Point(250, 320);

            lblEstado.Name =
                "lblEstado";

            lblEstado.Size =
                new Size(55, 20);

            lblEstado.Text =
                "Estado";

            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbEstado.Location =
                new Point(250, 345);

            cmbEstado.Name =
                "cmbEstado";

            cmbEstado.Size =
                new Size(190, 28);

            cmbEstado.TabIndex = 5;

            // 
            // btnGuardar
            // 
            btnGuardar.BackColor =
                Color.FromArgb(40, 167, 69);

            btnGuardar.FlatStyle =
                FlatStyle.Flat;

            btnGuardar.FlatAppearance.BorderSize = 0;

            btnGuardar.ForeColor =
                Color.White;

            btnGuardar.Location =
                new Point(80, 405);

            btnGuardar.Name =
                "btnGuardar";

            btnGuardar.Size =
                new Size(140, 42);

            btnGuardar.TabIndex = 6;

            btnGuardar.Text =
                "Guardar";

            btnGuardar.UseVisualStyleBackColor = false;

            // 
            // btnCancelar
            // 
            btnCancelar.BackColor =
                Color.Firebrick;

            btnCancelar.FlatStyle =
                FlatStyle.Flat;

            btnCancelar.FlatAppearance.BorderSize = 0;

            btnCancelar.ForeColor =
                Color.White;

            btnCancelar.Location =
                new Point(260, 405);

            btnCancelar.Name =
                "btnCancelar";

            btnCancelar.Size =
                new Size(140, 42);

            btnCancelar.TabIndex = 7;

            btnCancelar.Text =
                "Cancelar";

            btnCancelar.UseVisualStyleBackColor = false;

            // 
            // FrmNuevoUsuario
            // 
            AutoScaleDimensions =
                new SizeF(9F, 23F);

            AutoScaleMode =
                AutoScaleMode.Font;

            BackColor =
                Color.White;

            ClientSize =
                new Size(480, 490);

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

            Font =
                new Font("Segoe UI", 10F);

            Name =
                "FrmNuevoUsuario";

            StartPosition =
                FormStartPosition.CenterParent;

            Text =
                "Usuario";

            Load +=
                FrmNuevoUsuario_Load_1;

            ResumeLayout(false);
            PerformLayout();
        }
    }
}