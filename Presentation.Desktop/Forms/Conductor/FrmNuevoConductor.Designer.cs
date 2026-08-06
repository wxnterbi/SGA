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
            if (disposing && components != null)
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
            
            // lblTitulo
            
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(170, 35);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(276, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registrar Conductor";
            
            // lblNombre
            
            lblNombre.Location = new Point(70, 110);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(100, 23);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            
            // lblCedula
            
            lblCedula.Location = new Point(70, 170);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(100, 23);
            lblCedula.TabIndex = 2;
            lblCedula.Text = "Cédula:";
            
            // lblLicencia
            
            lblLicencia.Location = new Point(70, 230);
            lblLicencia.Name = "lblLicencia";
            lblLicencia.Size = new Size(100, 23);
            lblLicencia.TabIndex = 3;
            lblLicencia.Text = "Licencia:";
            
            // lblTelefono
            
            lblTelefono.Location = new Point(70, 290);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(100, 23);
            lblTelefono.TabIndex = 4;
            lblTelefono.Text = "Teléfono:";
            
            // lblEstado
            
            lblEstado.Location = new Point(70, 350);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(100, 23);
            lblEstado.TabIndex = 5;
            lblEstado.Text = "Estado:";
            
            // txtNombre
            
            txtNombre.Location = new Point(180, 105);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(280, 27);
            txtNombre.TabIndex = 6;
            
            // txtCedula
            
            txtCedula.Location = new Point(180, 165);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(280, 27);
            txtCedula.TabIndex = 7;
            
            // txtLicencia
            
            txtLicencia.Location = new Point(180, 225);
            txtLicencia.Name = "txtLicencia";
            txtLicencia.Size = new Size(280, 27);
            txtLicencia.TabIndex = 8;
            
            // txtTelefono
            
            txtTelefono.Location = new Point(180, 285);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(280, 27);
            txtTelefono.TabIndex = 9;
            
            // cmbEstado
            
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.Location = new Point(180, 345);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(280, 28);
            cmbEstado.TabIndex = 10;
            
            // btnGuardar
            
            btnGuardar.BackColor = Color.FromArgb(40, 167, 69);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(160, 440);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(110, 45);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            
            // btnCancelar
            
            btnCancelar.Location = new Point(300, 440);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(110, 45);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            
            // FrmNuevoConductor
            
            ClientSize = new Size(520, 560);
            Controls.Add(lblTitulo);
            Controls.Add(lblNombre);
            Controls.Add(lblCedula);
            Controls.Add(lblLicencia);
            Controls.Add(lblTelefono);
            Controls.Add(lblEstado);
            Controls.Add(txtNombre);
            Controls.Add(txtCedula);
            Controls.Add(txtLicencia);
            Controls.Add(txtTelefono);
            Controls.Add(cmbEstado);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FrmNuevoConductor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo Conductor";
            Load += FrmNuevoConductor_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}