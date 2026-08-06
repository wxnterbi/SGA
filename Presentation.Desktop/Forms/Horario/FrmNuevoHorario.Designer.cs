namespace SGA.Presentation.Desktop.Forms.Horario
{
    partial class FrmNuevoHorario
    {
        private System.ComponentModel.IContainer components = null;


        private Label lblTitulo;

        private Label lblDiasOperacion;
        private ComboBox cmbDiasOperacion;

        private Label lblHoraSalida;
        private DateTimePicker dtpHoraSalida;

        private Label lblRuta;
        private ComboBox cmbRuta;

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
            lblDiasOperacion = new Label();
            cmbDiasOperacion = new ComboBox();
            lblHoraSalida = new Label();
            dtpHoraSalida = new DateTimePicker();
            lblRuta = new Label();
            cmbRuta = new ComboBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(40, 40, 40);
            lblTitulo.Location = new Point(210, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(329, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "REGISTRAR HORARIO";
            // 
            // lblDiasOperacion
            // 
            lblDiasOperacion.AutoSize = true;
            lblDiasOperacion.Location = new Point(80, 120);
            lblDiasOperacion.Name = "lblDiasOperacion";
            lblDiasOperacion.Size = new Size(147, 23);
            lblDiasOperacion.TabIndex = 1;
            lblDiasOperacion.Text = "Días de operación";
            // 
            // cmbDiasOperacion
            // 
            cmbDiasOperacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDiasOperacion.Location = new Point(80, 150);
            cmbDiasOperacion.Name = "cmbDiasOperacion";
            cmbDiasOperacion.Size = new Size(520, 31);
            cmbDiasOperacion.TabIndex = 2;
            cmbDiasOperacion.SelectedIndexChanged += cmbDiasOperacion_SelectedIndexChanged;
            // 
            // lblHoraSalida
            // 
            lblHoraSalida.AutoSize = true;
            lblHoraSalida.Location = new Point(80, 210);
            lblHoraSalida.Name = "lblHoraSalida";
            lblHoraSalida.Size = new Size(119, 23);
            lblHoraSalida.TabIndex = 3;
            lblHoraSalida.Text = "Hora de salida";
            // 
            // dtpHoraSalida
            // 
            dtpHoraSalida.Format = DateTimePickerFormat.Time;
            dtpHoraSalida.Location = new Point(80, 240);
            dtpHoraSalida.Name = "dtpHoraSalida";
            dtpHoraSalida.ShowUpDown = true;
            dtpHoraSalida.Size = new Size(220, 30);
            dtpHoraSalida.TabIndex = 4;
            // 
            // lblRuta
            // 
            lblRuta.AutoSize = true;
            lblRuta.Location = new Point(80, 300);
            lblRuta.Name = "lblRuta";
            lblRuta.Size = new Size(45, 23);
            lblRuta.TabIndex = 5;
            lblRuta.Text = "Ruta";
            // 
            // cmbRuta
            // 
            cmbRuta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRuta.Location = new Point(80, 330);
            cmbRuta.Name = "cmbRuta";
            cmbRuta.Size = new Size(520, 31);
            cmbRuta.TabIndex = 6;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(40, 167, 69);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(230, 420);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 45);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar Horario";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Firebrick;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(380, 420);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 45);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // FrmNuevoHorario
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(700, 520);
            Controls.Add(lblTitulo);
            Controls.Add(lblDiasOperacion);
            Controls.Add(cmbDiasOperacion);
            Controls.Add(lblHoraSalida);
            Controls.Add(dtpHoraSalida);
            Controls.Add(lblRuta);
            Controls.Add(cmbRuta);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Font = new Font("Segoe UI", 10F);
            Name = "FrmNuevoHorario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Horario";
            Load += FrmNuevoHorario_Load_2;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}