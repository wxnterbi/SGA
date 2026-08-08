namespace SGA.Presentation.Desktop.Forms.Viaje
{
    partial class FrmNuevoViaje
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;

        private Label lblRuta;
        private Label lblHorario;
        private Label lblAutobus;
        private Label lblConductor;
        private Label lblEstado;

        private ComboBox cmbRuta;
        private ComboBox cmbHorario;
        private ComboBox cmbAutobus;
        private ComboBox cmbConductor;
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

            lblRuta = new Label();
            lblHorario = new Label();
            lblAutobus = new Label();
            lblConductor = new Label();
            lblEstado = new Label();

            cmbRuta = new ComboBox();
            cmbHorario = new ComboBox();
            cmbAutobus = new ComboBox();
            cmbConductor = new ComboBox();
            cmbEstado = new ComboBox();

            btnGuardar = new Button();
            btnCancelar = new Button();

            SuspendLayout();

            // 
            // FrmNuevoViaje
            // 
            AutoScaleDimensions =
                new SizeF(9F, 23F);

            AutoScaleMode =
                AutoScaleMode.Font;

            BackColor =
                Color.White;

            ClientSize =
                new Size(520, 570);

            Font =
                new Font("Segoe UI", 10F);

            FormBorderStyle =
                FormBorderStyle.FixedDialog;

            MaximizeBox = false;
            MinimizeBox = false;

            Name =
                "FrmNuevoViaje";

            StartPosition =
                FormStartPosition.CenterParent;

            Text =
                "Nuevo Viaje";

            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;

            lblTitulo.Font =
                new Font(
                    "Segoe UI",
                    18F,
                    FontStyle.Bold);

            lblTitulo.ForeColor =
                Color.FromArgb(40, 40, 40);

            lblTitulo.Location =
                new Point(30, 25);

            lblTitulo.Name =
                "lblTitulo";

            lblTitulo.Size =
                new Size(210, 41);

            lblTitulo.Text =
                "NUEVO VIAJE";

            // 
            // lblRuta
            // 
            lblRuta.AutoSize = true;

            lblRuta.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);

            lblRuta.Location =
                new Point(40, 90);

            lblRuta.Text =
                "Ruta";

            // 
            // cmbRuta
            // 
            cmbRuta.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbRuta.FormattingEnabled = true;

            cmbRuta.Location =
                new Point(40, 115);

            cmbRuta.Name =
                "cmbRuta";

            cmbRuta.Size =
                new Size(440, 31);

            // 
            // lblHorario
            // 
            lblHorario.AutoSize = true;

            lblHorario.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);

            lblHorario.Location =
                new Point(40, 165);

            lblHorario.Text =
                "Horario";

            // 
            // cmbHorario
            // 
            cmbHorario.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbHorario.FormattingEnabled = true;

            cmbHorario.Location =
                new Point(40, 190);

            cmbHorario.Name =
                "cmbHorario";

            cmbHorario.Size =
                new Size(440, 31);

            // 
            // lblAutobus
            // 
            lblAutobus.AutoSize = true;

            lblAutobus.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);

            lblAutobus.Location =
                new Point(40, 240);

            lblAutobus.Text =
                "Autobús";

            // 
            // cmbAutobus
            // 
            cmbAutobus.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbAutobus.FormattingEnabled = true;

            cmbAutobus.Location =
                new Point(40, 265);

            cmbAutobus.Name =
                "cmbAutobus";

            cmbAutobus.Size =
                new Size(440, 31);

            // 
            // lblConductor
            // 
            lblConductor.AutoSize = true;

            lblConductor.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);

            lblConductor.Location =
                new Point(40, 315);

            lblConductor.Text =
                "Conductor";

            // 
            // cmbConductor
            // 
            cmbConductor.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbConductor.FormattingEnabled = true;

            cmbConductor.Location =
                new Point(40, 340);

            cmbConductor.Name =
                "cmbConductor";

            cmbConductor.Size =
                new Size(440, 31);

            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;

            lblEstado.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);

            lblEstado.Location =
                new Point(40, 390);

            lblEstado.Text =
                "Estado";

            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbEstado.FormattingEnabled = true;

            cmbEstado.Location =
                new Point(40, 415);

            cmbEstado.Name =
                "cmbEstado";

            cmbEstado.Size =
                new Size(440, 31);

            // 
            // btnGuardar
            // 
            btnGuardar.BackColor =
                Color.FromArgb(40, 167, 69);

            btnGuardar.Cursor =
                Cursors.Hand;

            btnGuardar.FlatStyle =
                FlatStyle.Flat;

            btnGuardar.FlatAppearance.BorderSize =
                0;

            btnGuardar.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);

            btnGuardar.ForeColor =
                Color.White;

            btnGuardar.Location =
                new Point(90, 480);

            btnGuardar.Name =
                "btnGuardar";

            btnGuardar.Size =
                new Size(150, 42);

            btnGuardar.TabIndex =
                7;

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

            btnCancelar.FlatAppearance.BorderSize =
                0;

            btnCancelar.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);

            btnCancelar.ForeColor =
                Color.White;

            btnCancelar.Location =
                new Point(280, 480);

            btnCancelar.Name =
                "btnCancelar";

            btnCancelar.Size =
                new Size(150, 42);

            btnCancelar.TabIndex =
                8;

            btnCancelar.Text =
                "Cancelar";

            btnCancelar.UseVisualStyleBackColor =
                false;

            // 
            // Controls
            // 
            Controls.Add(lblTitulo);

            Controls.Add(lblRuta);
            Controls.Add(cmbRuta);

            Controls.Add(lblHorario);
            Controls.Add(cmbHorario);

            Controls.Add(lblAutobus);
            Controls.Add(cmbAutobus);

            Controls.Add(lblConductor);
            Controls.Add(cmbConductor);

            Controls.Add(lblEstado);
            Controls.Add(cmbEstado);

            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);

            ResumeLayout(false);
            PerformLayout();
        }
    }
}