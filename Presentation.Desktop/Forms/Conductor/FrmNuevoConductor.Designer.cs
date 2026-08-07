namespace SGA.Presentation.Desktop.Forms.Conductor
{
    partial class FrmNuevoConductor
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;

        private Label lblNombre;
        private TextBox txtNombre;

        private Label lblCedula;
        private TextBox txtCedula;

        private Label lblLicencia;
        private TextBox txtLicencia;

        private Label lblTelefono;
        private TextBox txtTelefono;

        private Label lblEstado;
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
            txtNombre = new TextBox();

            lblCedula = new Label();
            txtCedula = new TextBox();

            lblLicencia = new Label();
            txtLicencia = new TextBox();

            lblTelefono = new Label();
            txtTelefono = new TextBox();

            lblEstado = new Label();
            cmbEstado = new ComboBox();

            btnGuardar = new Button();
            btnCancelar = new Button();

            SuspendLayout();

            
            // lblTitulo
            
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(40, 40, 40);
            lblTitulo.Location = new Point(180, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(360, 41);
            lblTitulo.Text = "REGISTRAR CONDUCTOR";

            
            // lblNombre
            
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(80, 120);
            lblNombre.Text = "Nombre";

            
            // txtNombre
            
            txtNombre.Location = new Point(80, 150);
            txtNombre.Size = new Size(520, 30);

            
            // lblCedula
            
            lblCedula.AutoSize = true;
            lblCedula.Location = new Point(80, 200);
            lblCedula.Text = "Cédula";

            
            // txtCedula
            
            txtCedula.Location = new Point(80, 230);
            txtCedula.Size = new Size(520, 30);

            
            // lblLicencia
            
            lblLicencia.AutoSize = true;
            lblLicencia.Location = new Point(80, 280);
            lblLicencia.Text = "Licencia";

            
            // txtLicencia
            
            txtLicencia.Location = new Point(80, 310);
            txtLicencia.Size = new Size(520, 30);

            
            // lblTelefono
            
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(80, 360);
            lblTelefono.Text = "Teléfono";

            
            // txtTelefono
            
            txtTelefono.Location = new Point(80, 390);
            txtTelefono.Size = new Size(520, 30);

            
            // lblEstado
            
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(80, 440);
            lblEstado.Text = "Estado";

            
            // cmbEstado
            
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.Location = new Point(80, 470);
            cmbEstado.Size = new Size(520, 31);

            
            // btnGuardar
            
            btnGuardar.BackColor = Color.FromArgb(40, 167, 69);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(210, 560);
            btnGuardar.Size = new Size(130, 45);
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;

            
            // btnCancelar
            
            btnCancelar.BackColor = Color.Firebrick;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(370, 560);
            btnCancelar.Size = new Size(130, 45);
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;

            
            // FrmNuevoConductor
            
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(700, 650);

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

            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FrmNuevoConductor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Conductor";

            Load += FrmNuevoConductor_Load_1;

            ResumeLayout(false);
            PerformLayout();
        }
    }
}