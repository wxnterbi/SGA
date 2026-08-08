namespace SGA.Presentation.Desktop.Forms.Incidencia
{
    partial class FrmNuevaIncidencia
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;

        private Label lblViaje;
        private Label lblConductor;
        private Label lblTipo;
        private Label lblDescripcion;
        private Label lblFecha;

        private ComboBox cmbViaje;
        private ComboBox cmbConductor;
        private ComboBox cmbTipo;

        private TextBox txtDescripcion;

        private DateTimePicker dtpFecha;

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

            lblViaje = new Label();
            lblConductor = new Label();
            lblTipo = new Label();
            lblDescripcion = new Label();
            lblFecha = new Label();

            cmbViaje = new ComboBox();
            cmbConductor = new ComboBox();
            cmbTipo = new ComboBox();

            txtDescripcion = new TextBox();

            dtpFecha = new DateTimePicker();

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
                new Point(120, 25);

            lblTitulo.Name =
                "lblTitulo";

            lblTitulo.Size =
                new Size(260, 37);

            lblTitulo.TabIndex =
                0;

            lblTitulo.Text =
                "NUEVA INCIDENCIA";

            // 
            // lblViaje
            // 
            lblViaje.AutoSize = true;

            lblViaje.Location =
                new Point(40, 85);

            lblViaje.Name =
                "lblViaje";

            lblViaje.Size =
                new Size(45, 20);

            lblViaje.TabIndex =
                1;

            lblViaje.Text =
                "Viaje";

            // 
            // cmbViaje
            // 
            cmbViaje.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbViaje.FormattingEnabled =
                true;

            cmbViaje.Location =
                new Point(40, 110);

            cmbViaje.Name =
                "cmbViaje";

            cmbViaje.Size =
                new Size(380, 28);

            cmbViaje.TabIndex =
                2;

            // 
            // lblConductor
            // 
            lblConductor.AutoSize = true;

            lblConductor.Location =
                new Point(40, 155);

            lblConductor.Name =
                "lblConductor";

            lblConductor.Size =
                new Size(82, 20);

            lblConductor.TabIndex =
                3;

            lblConductor.Text =
                "Conductor";

            // 
            // cmbConductor
            // 
            cmbConductor.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbConductor.FormattingEnabled =
                true;

            cmbConductor.Location =
                new Point(40, 180);

            cmbConductor.Name =
                "cmbConductor";

            cmbConductor.Size =
                new Size(380, 28);

            cmbConductor.TabIndex =
                4;

            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;

            lblTipo.Location =
                new Point(40, 225);

            lblTipo.Name =
                "lblTipo";

            lblTipo.Size =
                new Size(39, 20);

            lblTipo.TabIndex =
                5;

            lblTipo.Text =
                "Tipo";

            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbTipo.FormattingEnabled =
                true;

            cmbTipo.Location =
                new Point(40, 250);

            cmbTipo.Name =
                "cmbTipo";

            cmbTipo.Size =
                new Size(380, 28);

            cmbTipo.TabIndex =
                6;

            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;

            lblDescripcion.Location =
                new Point(40, 295);

            lblDescripcion.Name =
                "lblDescripcion";

            lblDescripcion.Size =
                new Size(89, 20);

            lblDescripcion.TabIndex =
                7;

            lblDescripcion.Text =
                "Descripción";

            // 
            // txtDescripcion
            // 
            txtDescripcion.Location =
                new Point(40, 320);

            txtDescripcion.Multiline =
                true;

            txtDescripcion.Name =
                "txtDescripcion";

            txtDescripcion.ScrollBars =
                ScrollBars.Vertical;

            txtDescripcion.Size =
                new Size(380, 80);

            txtDescripcion.TabIndex =
                8;

            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;

            lblFecha.Location =
                new Point(40, 425);

            lblFecha.Name =
                "lblFecha";

            lblFecha.Size =
                new Size(45, 20);

            lblFecha.TabIndex =
                9;

            lblFecha.Text =
                "Fecha";

            // 
            // dtpFecha
            // 
            dtpFecha.CustomFormat =
                "dd/MM/yyyy HH:mm";

            dtpFecha.Format =
                DateTimePickerFormat.Custom;

            dtpFecha.Location =
                new Point(40, 450);

            dtpFecha.Name =
                "dtpFecha";

            dtpFecha.Size =
                new Size(220, 27);

            dtpFecha.TabIndex =
                10;

            // 
            // btnGuardar
            // 
            btnGuardar.BackColor =
                Color.FromArgb(40, 167, 69);

            btnGuardar.FlatStyle =
                FlatStyle.Flat;

            btnGuardar.FlatAppearance.BorderSize =
                0;

            btnGuardar.ForeColor =
                Color.White;

            btnGuardar.Location =
                new Point(90, 515);

            btnGuardar.Name =
                "btnGuardar";

            btnGuardar.Size =
                new Size(130, 40);

            btnGuardar.TabIndex =
                11;

            btnGuardar.Text =
                "Guardar";

            btnGuardar.UseVisualStyleBackColor =
                false;

            // 
            // btnCancelar
            // 
            btnCancelar.BackColor =
                Color.Firebrick;

            btnCancelar.FlatStyle =
                FlatStyle.Flat;

            btnCancelar.FlatAppearance.BorderSize =
                0;

            btnCancelar.ForeColor =
                Color.White;

            btnCancelar.Location =
                new Point(250, 515);

            btnCancelar.Name =
                "btnCancelar";

            btnCancelar.Size =
                new Size(130, 40);

            btnCancelar.TabIndex =
                12;

            btnCancelar.Text =
                "Cancelar";

            btnCancelar.UseVisualStyleBackColor =
                false;

            // 
            // FrmNuevaIncidencia
            // 
            AutoScaleDimensions =
                new SizeF(8F, 20F);

            AutoScaleMode =
                AutoScaleMode.Font;

            BackColor =
                Color.White;

            ClientSize =
                new Size(470, 600);

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

            Font =
                new Font("Segoe UI", 10F);

            Name =
                "FrmNuevaIncidencia";

            StartPosition =
                FormStartPosition.CenterParent;

            Text =
                "Incidencia";

            Load +=
                FrmNuevaIncidencia_Load;

            ResumeLayout(false);
            PerformLayout();
        }
    }
}