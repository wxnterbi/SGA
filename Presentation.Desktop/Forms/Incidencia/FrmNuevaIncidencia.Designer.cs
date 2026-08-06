namespace SGA.Presentation.Desktop.Forms.Incidencia
{
    partial class FrmNuevaIncidencia
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;

        private Label lblViaje;
        private ComboBox cmbViaje;

        private Label lblConductor;
        private ComboBox cmbConductor;

        private Label lblTipo;
        private ComboBox cmbTipo;

        private Label lblDescripcion;
        private TextBox txtDescripcion;

        private Label lblFecha;
        private DateTimePicker dtpFecha;

        private Button btnGuardar;
        private Button btnCancelar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblViaje = new Label();
            cmbViaje = new ComboBox();
            lblConductor = new Label();
            cmbConductor = new ComboBox();
            lblTipo = new Label();
            cmbTipo = new ComboBox();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            btnGuardar = new Button();
            btnCancelar = new Button();
            SuspendLayout();

            
            // lblTitulo
            
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(40, 40, 40);
            lblTitulo.Location = new Point(165, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(374, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "REGISTRAR INCIDENCIA";

            
            // lblViaje
            
            lblViaje.AutoSize = true;
            lblViaje.Location = new Point(70, 100);
            lblViaje.Name = "lblViaje";
            lblViaje.Size = new Size(52, 23);
            lblViaje.Text = "Viaje";


            // cmbViaje

            cmbViaje.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbViaje.FormattingEnabled = true;
            cmbViaje.Location = new Point(70, 130);
            cmbViaje.Name = "cmbViaje";
            cmbViaje.Size = new Size(560, 31);

            
            // lblConductor
            
            lblConductor.AutoSize = true;
            lblConductor.Location = new Point(70, 180);
            lblConductor.Name = "lblConductor";
            lblConductor.Size = new Size(93, 23);
            lblConductor.Text = "Conductor";


            // cmbConductor

            cmbConductor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbConductor.FormattingEnabled = true;
            cmbConductor.Location = new Point(70, 210);
            cmbConductor.Name = "cmbConductor";
            cmbConductor.Size = new Size(560, 31);


            // lblTipo

            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(70, 260);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(42, 23);
            lblTipo.Text = "Tipo";


            // cmbTipo

            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(70, 290);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(560, 31);


            // lblDescripcion

            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(70, 340);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(102, 23);
            lblDescripcion.Text = "Descripción";


            // txtDescripcion

            txtDescripcion.Location = new Point(70, 370);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.ScrollBars = ScrollBars.Vertical;
            txtDescripcion.Size = new Size(560, 90);


            // lblFecha

            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(70, 480);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(56, 23);
            lblFecha.Text = "Fecha";


            // dtpFecha

            dtpFecha.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.Location = new Point(70, 510);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(250, 30);


            // btnGuardar

            btnGuardar.BackColor = Color.FromArgb(40, 167, 69);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(190, 580);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(140, 45);
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;


            // btnCancelar

            btnCancelar.BackColor = Color.Firebrick;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(360, 580);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(140, 45);
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;

            // FrmNuevaIncidencia

            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(700, 670);
            Controls.Add(lblTitulo);
            Controls.Add(lblViaje);
            Controls.Add(cmbViaje);
            Controls.Add(lblConductor);
            Controls.Add(cmbConductor);
            Controls.Add(lblTipo);
            Controls.Add(cmbTipo);
            Controls.Add(lblDescripcion);
            Controls.Add(txtDescripcion);
            Controls.Add(lblFecha);
            Controls.Add(dtpFecha);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Font = new Font("Segoe UI", 10F);
            Name = "FrmNuevaIncidencia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Incidencia";
            Load += FrmNuevaIncidencia_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}