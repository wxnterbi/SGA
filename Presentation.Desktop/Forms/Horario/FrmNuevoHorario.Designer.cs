namespace SGA.Presentation.Desktop.Forms.Horario
{
    partial class FrmNuevoHorario
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;

        private Label lblDiasOperacion;
        private Label lblHoraSalida;
        private Label lblRuta;

        private ComboBox cmbDiasOperacion;
        private DateTimePicker dtpHoraSalida;
        private ComboBox cmbRuta;

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

            lblDiasOperacion = new Label();
            lblHoraSalida = new Label();
            lblRuta = new Label();

            cmbDiasOperacion = new ComboBox();
            dtpHoraSalida = new DateTimePicker();
            cmbRuta = new ComboBox();

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
                Color.FromArgb(25, 42, 86);

            lblTitulo.Location =
                new Point(100, 25);

            lblTitulo.Name =
                "lblTitulo";

            lblTitulo.Size =
                new Size(250, 41);

            lblTitulo.TabIndex = 0;

            lblTitulo.Text =
                "NUEVO HORARIO";

            // 
            // lblDiasOperacion
            // 
            lblDiasOperacion.AutoSize = true;

            lblDiasOperacion.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);

            lblDiasOperacion.Location =
                new Point(45, 95);

            lblDiasOperacion.Name =
                "lblDiasOperacion";

            lblDiasOperacion.Size =
                new Size(150, 23);

            lblDiasOperacion.TabIndex = 1;

            lblDiasOperacion.Text =
                "Días de operación";

            // 
            // cmbDiasOperacion
            // 
            cmbDiasOperacion.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbDiasOperacion.FormattingEnabled = true;

            cmbDiasOperacion.Location =
                new Point(45, 122);

            cmbDiasOperacion.Name =
                "cmbDiasOperacion";

            cmbDiasOperacion.Size =
                new Size(390, 31);

            cmbDiasOperacion.TabIndex = 2;

            // 
            // lblHoraSalida
            // 
            lblHoraSalida.AutoSize = true;

            lblHoraSalida.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);

            lblHoraSalida.Location =
                new Point(45, 175);

            lblHoraSalida.Name =
                "lblHoraSalida";

            lblHoraSalida.Size =
                new Size(110, 23);

            lblHoraSalida.TabIndex = 3;

            lblHoraSalida.Text =
                "Hora de salida";

            // 
            // dtpHoraSalida
            // 
            dtpHoraSalida.Format =
                DateTimePickerFormat.Time;

            dtpHoraSalida.Location =
                new Point(45, 202);

            dtpHoraSalida.Name =
                "dtpHoraSalida";

            dtpHoraSalida.ShowUpDown = true;

            dtpHoraSalida.Size =
                new Size(180, 30);

            dtpHoraSalida.TabIndex = 4;

            // 
            // lblRuta
            // 
            lblRuta.AutoSize = true;

            lblRuta.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);

            lblRuta.Location =
                new Point(45, 255);

            lblRuta.Name =
                "lblRuta";

            lblRuta.Size =
                new Size(45, 23);

            lblRuta.TabIndex = 5;

            lblRuta.Text =
                "Ruta";

            // 
            // cmbRuta
            // 
            cmbRuta.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbRuta.FormattingEnabled = true;

            cmbRuta.Location =
                new Point(45, 282);

            cmbRuta.Name =
                "cmbRuta";

            cmbRuta.Size =
                new Size(390, 31);

            cmbRuta.TabIndex = 6;

            // 
            // btnGuardar
            // 
            btnGuardar.BackColor =
                Color.FromArgb(40, 167, 69);

            btnGuardar.FlatStyle =
                FlatStyle.Flat;

            btnGuardar.ForeColor =
                Color.White;

            btnGuardar.Location =
                new Point(80, 350);

            btnGuardar.Name =
                "btnGuardar";

            btnGuardar.Size =
                new Size(140, 42);

            btnGuardar.TabIndex = 7;

            btnGuardar.Text =
                "Guardar";

            btnGuardar.UseVisualStyleBackColor = false;

            // 
            // btnCancelar
            // 
            btnCancelar.BackColor =
                Color.Gray;

            btnCancelar.FlatStyle =
                FlatStyle.Flat;

            btnCancelar.ForeColor =
                Color.White;

            btnCancelar.Location =
                new Point(260, 350);

            btnCancelar.Name =
                "btnCancelar";

            btnCancelar.Size =
                new Size(140, 42);

            btnCancelar.TabIndex = 8;

            btnCancelar.Text =
                "Cancelar";

            btnCancelar.UseVisualStyleBackColor = false;

            // 
            // FrmNuevoHorario
            // 
            AutoScaleDimensions =
                new SizeF(9F, 23F);

            AutoScaleMode =
                AutoScaleMode.Font;

            BackColor =
                Color.White;

            ClientSize =
                new Size(480, 450);

            Controls.Add(lblTitulo);

            Controls.Add(lblDiasOperacion);
            Controls.Add(cmbDiasOperacion);

            Controls.Add(lblHoraSalida);
            Controls.Add(dtpHoraSalida);

            Controls.Add(lblRuta);
            Controls.Add(cmbRuta);

            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);

            Font =
                new Font("Segoe UI", 10F);

            FormBorderStyle =
                FormBorderStyle.FixedDialog;

            MaximizeBox = false;
            MinimizeBox = false;

            Name =
                "FrmNuevoHorario";

            StartPosition =
                FormStartPosition.CenterParent;

            Text =
                "Nuevo Horario";

            Load +=
                FrmNuevoHorario_Load;

            ResumeLayout(false);
            PerformLayout();
        }
    }
}