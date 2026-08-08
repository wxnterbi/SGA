namespace SGA.Presentation.Desktop.Forms.Viaje
{
    partial class FrmDetalleViaje
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;

        private Label lblRutaTitulo;
        private Label lblHorarioTitulo;
        private Label lblAutobusTitulo;
        private Label lblConductorTitulo;
        private Label lblEstadoTitulo;

        private Label lblRuta;
        private Label lblHorario;
        private Label lblAutobus;
        private Label lblConductor;
        private Label lblEstado;

        private Button btnCerrar;

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

            lblRutaTitulo = new Label();
            lblHorarioTitulo = new Label();
            lblAutobusTitulo = new Label();
            lblConductorTitulo = new Label();
            lblEstadoTitulo = new Label();

            lblRuta = new Label();
            lblHorario = new Label();
            lblAutobus = new Label();
            lblConductor = new Label();
            lblEstado = new Label();

            btnCerrar = new Button();

            SuspendLayout();

            // 
            // FrmDetalleViaje
            // 
            AutoScaleDimensions =
                new SizeF(9F, 23F);

            AutoScaleMode =
                AutoScaleMode.Font;

            BackColor =
                Color.White;

            ClientSize =
                new Size(600, 430);

            Font =
                new Font("Segoe UI", 10F);

            FormBorderStyle =
                FormBorderStyle.FixedDialog;

            MaximizeBox =
                false;

            MinimizeBox =
                false;

            Name =
                "FrmDetalleViaje";

            StartPosition =
                FormStartPosition.CenterParent;

            Text =
                "Detalle del Viaje";

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
                Color.FromArgb(25, 42, 86);

            lblTitulo.Location =
                new Point(30, 20);

            lblTitulo.Name =
                "lblTitulo";

            lblTitulo.Size =
                new Size(270, 41);

            lblTitulo.TabIndex =
                0;

            lblTitulo.Text =
                "DETALLE DEL VIAJE";

            // 
            // lblRutaTitulo
            // 
            lblRutaTitulo.AutoSize = true;

            lblRutaTitulo.Font =
                new Font(
                    "Segoe UI",
                    11F,
                    FontStyle.Bold);

            lblRutaTitulo.Location =
                new Point(40, 90);

            lblRutaTitulo.Name =
                "lblRutaTitulo";

            lblRutaTitulo.Size =
                new Size(45, 25);

            lblRutaTitulo.Text =
                "Ruta:";

            // 
            // lblHorarioTitulo
            // 
            lblHorarioTitulo.AutoSize = true;

            lblHorarioTitulo.Font =
                new Font(
                    "Segoe UI",
                    11F,
                    FontStyle.Bold);

            lblHorarioTitulo.Location =
                new Point(40, 135);

            lblHorarioTitulo.Name =
                "lblHorarioTitulo";

            lblHorarioTitulo.Size =
                new Size(75, 25);

            lblHorarioTitulo.Text =
                "Horario:";

            // 
            // lblAutobusTitulo
            // 
            lblAutobusTitulo.AutoSize = true;

            lblAutobusTitulo.Font =
                new Font(
                    "Segoe UI",
                    11F,
                    FontStyle.Bold);

            lblAutobusTitulo.Location =
                new Point(40, 180);

            lblAutobusTitulo.Name =
                "lblAutobusTitulo";

            lblAutobusTitulo.Size =
                new Size(85, 25);

            lblAutobusTitulo.Text =
                "Autobús:";

            // 
            // lblConductorTitulo
            // 
            lblConductorTitulo.AutoSize = true;

            lblConductorTitulo.Font =
                new Font(
                    "Segoe UI",
                    11F,
                    FontStyle.Bold);

            lblConductorTitulo.Location =
                new Point(40, 225);

            lblConductorTitulo.Name =
                "lblConductorTitulo";

            lblConductorTitulo.Size =
                new Size(95, 25);

            lblConductorTitulo.Text =
                "Conductor:";

            // 
            // lblEstadoTitulo
            // 
            lblEstadoTitulo.AutoSize = true;

            lblEstadoTitulo.Font =
                new Font(
                    "Segoe UI",
                    11F,
                    FontStyle.Bold);

            lblEstadoTitulo.Location =
                new Point(40, 270);

            lblEstadoTitulo.Name =
                "lblEstadoTitulo";

            lblEstadoTitulo.Size =
                new Size(65, 25);

            lblEstadoTitulo.Text =
                "Estado:";

            // 
            // lblRuta
            // 
            lblRuta.AutoSize = true;

            lblRuta.Font =
                new Font(
                    "Segoe UI",
                    11F);

            lblRuta.Location =
                new Point(180, 90);

            lblRuta.Name =
                "lblRuta";

            lblRuta.Size =
                new Size(40, 25);

            lblRuta.Text =
                "-";

            // 
            // lblHorario
            // 
            lblHorario.AutoSize = true;

            lblHorario.Font =
                new Font(
                    "Segoe UI",
                    11F);

            lblHorario.Location =
                new Point(180, 135);

            lblHorario.Name =
                "lblHorario";

            lblHorario.Size =
                new Size(40, 25);

            lblHorario.Text =
                "-";

            // 
            // lblAutobus
            // 
            lblAutobus.AutoSize = true;

            lblAutobus.Font =
                new Font(
                    "Segoe UI",
                    11F);

            lblAutobus.Location =
                new Point(180, 180);

            lblAutobus.Name =
                "lblAutobus";

            lblAutobus.Size =
                new Size(40, 25);

            lblAutobus.Text =
                "-";

            // 
            // lblConductor
            // 
            lblConductor.AutoSize = true;

            lblConductor.Font =
                new Font(
                    "Segoe UI",
                    11F);

            lblConductor.Location =
                new Point(180, 225);

            lblConductor.Name =
                "lblConductor";

            lblConductor.Size =
                new Size(40, 25);

            lblConductor.Text =
                "-";

            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;

            lblEstado.Font =
                new Font(
                    "Segoe UI",
                    11F);

            lblEstado.Location =
                new Point(180, 270);

            lblEstado.Name =
                "lblEstado";

            lblEstado.Size =
                new Size(40, 25);

            lblEstado.Text =
                "-";

            // 
            // btnCerrar
            // 
            btnCerrar.BackColor =
                Color.FromArgb(25, 42, 86);

            btnCerrar.Cursor =
                Cursors.Hand;

            btnCerrar.FlatAppearance.BorderSize =
                0;

            btnCerrar.FlatStyle =
                FlatStyle.Flat;

            btnCerrar.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);

            btnCerrar.ForeColor =
                Color.White;

            btnCerrar.Location =
                new Point(240, 340);

            btnCerrar.Name =
                "btnCerrar";

            btnCerrar.Size =
                new Size(120, 40);

            btnCerrar.TabIndex =
                6;

            btnCerrar.Text =
                "Cerrar";

            btnCerrar.UseVisualStyleBackColor =
                false;

            btnCerrar.Click +=
                btnCerrar_Click;

            // 
            // Controls
            // 
            Controls.Add(lblTitulo);

            Controls.Add(lblRutaTitulo);
            Controls.Add(lblHorarioTitulo);
            Controls.Add(lblAutobusTitulo);
            Controls.Add(lblConductorTitulo);
            Controls.Add(lblEstadoTitulo);

            Controls.Add(lblRuta);
            Controls.Add(lblHorario);
            Controls.Add(lblAutobus);
            Controls.Add(lblConductor);
            Controls.Add(lblEstado);

            Controls.Add(btnCerrar);

            Load +=
                FrmDetalleViaje_Load;

            ResumeLayout(false);
            PerformLayout();
        }
    }
}