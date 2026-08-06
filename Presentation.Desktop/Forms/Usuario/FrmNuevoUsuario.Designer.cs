namespace SGA.Presentation.Desktop.Forms.Usuario
{
    partial class FrmNuevoUsuario
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitulo = new Label();

            lblIdentificador = new Label();
            txtIdentificador = new TextBox();

            lblNombre = new Label();
            txtNombre = new TextBox();

            lblTipo = new Label();
            cmbTipoUsuario = new ComboBox();

            lblEstado = new Label();
            cmbEstado = new ComboBox();

            btnGuardar = new Button();
            btnCancelar = new Button();

            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(115, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(190, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registrar Usuario";

            //
            // lblIdentificador
            //
            lblIdentificador.AutoSize = true;
            lblIdentificador.Location = new Point(40, 80);
            lblIdentificador.Name = "lblIdentificador";
            lblIdentificador.Size = new Size(88, 15);
            lblIdentificador.TabIndex = 1;
            lblIdentificador.Text = "Identificador";

            //
            // txtIdentificador
            //
            txtIdentificador.Location = new Point(40, 100);
            txtIdentificador.Name = "txtIdentificador";
            txtIdentificador.Size = new Size(320, 23);
            txtIdentificador.TabIndex = 2;

            //
            // lblNombre
            //
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(40, 140);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";

            //
            // txtNombre
            //
            txtNombre.Location = new Point(40, 160);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(320, 23);
            txtNombre.TabIndex = 4;

            //
            // lblTipo
            //
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(40, 200);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(96, 15);
            lblTipo.TabIndex = 5;
            lblTipo.Text = "Tipo de Usuario";

            //
            // cmbTipoUsuario
            //
            cmbTipoUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoUsuario.FormattingEnabled = true;
            cmbTipoUsuario.Location = new Point(40, 220);
            cmbTipoUsuario.Name = "cmbTipoUsuario";
            cmbTipoUsuario.Size = new Size(320, 23);
            cmbTipoUsuario.TabIndex = 6;
            //
            // lblEstado
            //
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(40, 260);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(45, 15);
            lblEstado.TabIndex = 7;
            lblEstado.Text = "Estado";

            //
            // cmbEstado
            //
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(40, 280);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(320, 23);
            cmbEstado.TabIndex = 8;

            //
            // btnGuardar
            //
            btnGuardar.Location = new Point(70, 340);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(110, 38);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;

            //
            // btnCancelar
            //
            btnCancelar.Location = new Point(220, 340);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(110, 38);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;

            //
            // FrmNuevoUsuario
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 420);

            Controls.Add(lblTitulo);

            Controls.Add(lblIdentificador);
            Controls.Add(txtIdentificador);

            Controls.Add(lblNombre);
            Controls.Add(txtNombre);

            Controls.Add(lblTipo);
            Controls.Add(cmbTipoUsuario);

            Controls.Add(lblEstado);
            Controls.Add(cmbEstado);

            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);

            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Name = "FrmNuevoUsuario";
            Text = "Nuevo Usuario";

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitulo;

        private Label lblIdentificador;
        private TextBox txtIdentificador;

        private Label lblNombre;
        private TextBox txtNombre;

        private Label lblTipo;
        private ComboBox cmbTipoUsuario;

        private Label lblEstado;
        private ComboBox cmbEstado;

        private Button btnGuardar;
        private Button btnCancelar;
    }
}