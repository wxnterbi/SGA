namespace SGA.Presentation.Desktop.Forms.Conductor
{
    partial class FrmNuevoConductor
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;

        private Label lblNombre;
        private Label lblCedula;
        private Label lblLicencia;
        private Label lblTelefono;
        private Label lblEstado;

        private TextBox txtNombre;
        private TextBox txtCedula;
        private TextBox txtLicencia;
        private TextBox txtTelefono;

        private ComboBox cmbEstado;

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

            lblNombre = new Label();
            lblCedula = new Label();
            lblLicencia = new Label();
            lblTelefono = new Label();
            lblEstado = new Label();

            txtNombre = new TextBox();
            txtCedula = new TextBox();
            txtLicencia = new TextBox();
            txtTelefono = new TextBox();

            cmbEstado = new ComboBox();

            btnGuardar = new Button();
            btnCancelar = new Button();

            SuspendLayout();

            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;

            lblTitulo.Font =
                new Font(
                    "Segoe UI",
                    16F,
                    FontStyle.Bold);

            lblTitulo.ForeColor =
                Color.FromArgb(40, 40, 40);

            lblTitulo.Location =
                new Point(95, 25);

            lblTitulo.Name =
                "lblTitulo";

            lblTitulo.Size =
                new Size(270, 37);

            lblTitulo.TabIndex = 0;

            lblTitulo.Text =
                "NUEVO CONDUCTOR";

            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;

            lblNombre.Font =
                new Font("Segoe UI", 10F);

            lblNombre.Location =
                new Point(40, 85);

            lblNombre.Name =
                "lblNombre";

            lblNombre.Size =
                new Size(64, 23);

            lblNombre.TabIndex = 1;

            lblNombre.Text =
                "Nombre";

            // 
            // txtNombre
            // 
            txtNombre.Font =
                new Font("Segoe UI", 10F);

            txtNombre.Location =
                new Point(40, 112);

            txtNombre.Name =
                "txtNombre";

            txtNombre.Size =
                new Size(380, 30);

            txtNombre.TabIndex = 2;

            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;

            lblCedula.Font =
                new Font("Segoe UI", 10F);

            lblCedula.Location =
                new Point(40, 155);

            lblCedula.Name =
                "lblCedula";

            lblCedula.Size =
                new Size(58, 23);

            lblCedula.TabIndex = 3;

            lblCedula.Text =
                "Cédula";

            // 
            // txtCedula
            // 
            txtCedula.Font =
                new Font("Segoe UI", 10F);

            txtCedula.Location =
                new Point(40, 182);

            txtCedula.Name =
                "txtCedula";

            txtCedula.Size =
                new Size(380, 30);

            txtCedula.TabIndex = 4;

            // 
            // lblLicencia
            // 
            lblLicencia.AutoSize = true;

            lblLicencia.Font =
                new Font("Segoe UI", 10F);

            lblLicencia.Location =
                new Point(40, 225);

            lblLicencia.Name =
                "lblLicencia";

            lblLicencia.Size =
                new Size(70, 23);

            lblLicencia.TabIndex = 5;

            lblLicencia.Text =
                "Licencia";

            // 
            // txtLicencia
            // 
            txtLicencia.Font =
                new Font("Segoe UI", 10F);

            txtLicencia.Location =
                new Point(40, 252);

            txtLicencia.Name =
                "txtLicencia";

            txtLicencia.Size =
                new Size(380, 30);

            txtLicencia.TabIndex = 6;

            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;

            lblTelefono.Font =
                new Font("Segoe UI", 10F);

            lblTelefono.Location =
                new Point(40, 295);

            lblTelefono.Name =
                "lblTelefono";

            lblTelefono.Size =
                new Size(72, 23);

            lblTelefono.TabIndex = 7;

            lblTelefono.Text =
                "Teléfono";

            // 
            // txtTelefono
            // 
            txtTelefono.Font =
                new Font("Segoe UI", 10F);

            txtTelefono.Location =
                new Point(40, 322);

            txtTelefono.Name =
                "txtTelefono";

            txtTelefono.Size =
                new Size(180, 30);

            txtTelefono.TabIndex = 8;

            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;

            lblEstado.Font =
                new Font("Segoe UI", 10F);

            lblEstado.Location =
                new Point(245, 295);

            lblEstado.Name =
                "lblEstado";

            lblEstado.Size =
                new Size(55, 23);

            lblEstado.TabIndex = 9;

            lblEstado.Text =
                "Estado";

            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbEstado.Font =
                new Font("Segoe UI", 10F);

            cmbEstado.Location =
                new Point(245, 322);

            cmbEstado.Name =
                "cmbEstado";

            cmbEstado.Size =
                new Size(175, 31);

            cmbEstado.TabIndex = 10;

            // 
            // btnGuardar
            // 
            btnGuardar.BackColor =
                Color.FromArgb(40, 167, 69);

            btnGuardar.Cursor =
                Cursors.Hand;

            btnGuardar.FlatStyle =
                FlatStyle.Flat;

            btnGuardar.ForeColor =
                Color.White;

            btnGuardar.Location =
                new Point(75, 375);

            btnGuardar.Name =
                "btnGuardar";

            btnGuardar.Size =
                new Size(140, 42);

            btnGuardar.TabIndex = 11;

            btnGuardar.Text =
                "Guardar";

            btnGuardar.UseVisualStyleBackColor =
                false;

            // 
            // btnCancelar
            // 
            btnCancelar.BackColor =
                Color.Firebrick;

            btnCancelar.Cursor =
                Cursors.Hand;

            btnCancelar.FlatStyle =
                FlatStyle.Flat;

            btnCancelar.ForeColor =
                Color.White;

            btnCancelar.Location =
                new Point(245, 375);

            btnCancelar.Name =
                "btnCancelar";

            btnCancelar.Size =
                new Size(140, 42);

            btnCancelar.TabIndex = 12;

            btnCancelar.Text =
                "Cancelar";

            btnCancelar.UseVisualStyleBackColor =
                false;

            // 
            // FrmNuevoConductor
            // 
            AutoScaleDimensions =
                new SizeF(9F, 23F);

            AutoScaleMode =
                AutoScaleMode.Font;

            BackColor =
                Color.White;

            ClientSize =
                new Size(460, 455);

            Controls.Add(lblTitulo);

            Controls.Add(lblNombre);
            Controls.Add(txtNombre);

            Controls.Add(lblCedula);
            Controls.Add(txtCedula);

            Controls.Add(lblLicencia);
            Controls.Add(txtLicencia);

            Controls.Add(lblTelefono);
            Controls.Add(txtTelefono);

            Controls.Add(lblEstado);
            Controls.Add(cmbEstado);

            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);

            Font =
                new Font("Segoe UI", 10F);

            Name =
                "FrmNuevoConductor";

            StartPosition =
                FormStartPosition.CenterParent;

            Text =
                "Conductor";

            Load +=
                FrmNuevoConductor_Load;

            ResumeLayout(false);
            PerformLayout();
        }
    }
}