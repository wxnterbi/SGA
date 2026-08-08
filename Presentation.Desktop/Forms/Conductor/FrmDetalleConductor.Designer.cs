namespace SGA.Presentation.Desktop.Forms.Conductor
{
    partial class FrmDetalleConductor
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;

        private Label lblNombreTitulo;
        private Label lblCedulaTitulo;
        private Label lblLicenciaTitulo;
        private Label lblTelefonoTitulo;
        private Label lblEstadoTitulo;

        private Label lblNombre;
        private Label lblCedula;
        private Label lblLicencia;
        private Label lblTelefono;
        private Label lblEstado;

        private Button btnCerrar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components =
                new System.ComponentModel.Container();

            lblTitulo = new Label();

            lblNombreTitulo = new Label();
            lblCedulaTitulo = new Label();
            lblLicenciaTitulo = new Label();
            lblTelefonoTitulo = new Label();
            lblEstadoTitulo = new Label();

            lblNombre = new Label();
            lblCedula = new Label();
            lblLicencia = new Label();
            lblTelefono = new Label();
            lblEstado = new Label();

            btnCerrar = new Button();

            SuspendLayout();

            // 
            // FrmDetalleConductor
            // 
            ClientSize =
                new Size(600, 420);

            Text =
                "Detalle del Conductor";

            StartPosition =
                FormStartPosition.CenterParent;

            FormBorderStyle =
                FormBorderStyle.FixedDialog;

            MaximizeBox = false;

            MinimizeBox = false;

            BackColor =
                Color.White;

            Font =
                new Font("Segoe UI", 10F);

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
                new Size(280, 41);

            lblTitulo.TabIndex = 0;

            lblTitulo.Text =
                "DETALLE DEL CONDUCTOR";

            // 
            // Títulos
            // 
            lblNombreTitulo.AutoSize = true;
            lblNombreTitulo.Font =
                new Font(
                    "Segoe UI",
                    11F,
                    FontStyle.Bold);

            lblNombreTitulo.Location =
                new Point(40, 90);

            lblNombreTitulo.Text =
                "Nombre:";

            lblCedulaTitulo.AutoSize = true;
            lblCedulaTitulo.Font =
                new Font(
                    "Segoe UI",
                    11F,
                    FontStyle.Bold);

            lblCedulaTitulo.Location =
                new Point(40, 135);

            lblCedulaTitulo.Text =
                "Cédula:";

            lblLicenciaTitulo.AutoSize = true;
            lblLicenciaTitulo.Font =
                new Font(
                    "Segoe UI",
                    11F,
                    FontStyle.Bold);

            lblLicenciaTitulo.Location =
                new Point(40, 180);

            lblLicenciaTitulo.Text =
                "Licencia:";

            lblTelefonoTitulo.AutoSize = true;
            lblTelefonoTitulo.Font =
                new Font(
                    "Segoe UI",
                    11F,
                    FontStyle.Bold);

            lblTelefonoTitulo.Location =
                new Point(40, 225);

            lblTelefonoTitulo.Text =
                "Teléfono:";

            lblEstadoTitulo.AutoSize = true;
            lblEstadoTitulo.Font =
                new Font(
                    "Segoe UI",
                    11F,
                    FontStyle.Bold);

            lblEstadoTitulo.Location =
                new Point(40, 270);

            lblEstadoTitulo.Text =
                "Estado:";

            // 
            // Valores
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font =
                new Font("Segoe UI", 11F);

            lblNombre.Location =
                new Point(180, 90);

            lblNombre.Name =
                "lblNombre";

            lblCedula.AutoSize = true;
            lblCedula.Font =
                new Font("Segoe UI", 11F);

            lblCedula.Location =
                new Point(180, 135);

            lblCedula.Name =
                "lblCedula";

            lblLicencia.AutoSize = true;
            lblLicencia.Font =
                new Font("Segoe UI", 11F);

            lblLicencia.Location =
                new Point(180, 180);

            lblLicencia.Name =
                "lblLicencia";

            lblTelefono.AutoSize = true;
            lblTelefono.Font =
                new Font("Segoe UI", 11F);

            lblTelefono.Location =
                new Point(180, 225);

            lblTelefono.Name =
                "lblTelefono";

            lblEstado.AutoSize = true;
            lblEstado.Font =
                new Font("Segoe UI", 11F);

            lblEstado.Location =
                new Point(180, 270);

            lblEstado.Name =
                "lblEstado";

            // 
            // btnCerrar
            // 
            btnCerrar.Text =
                "Cerrar";

            btnCerrar.Size =
                new Size(120, 40);

            btnCerrar.Location =
                new Point(230, 340);

            btnCerrar.BackColor =
                Color.FromArgb(25, 42, 86);

            btnCerrar.ForeColor =
                Color.White;

            btnCerrar.FlatStyle =
                FlatStyle.Flat;

            btnCerrar.FlatAppearance.BorderSize =
                0;

            btnCerrar.Cursor =
                Cursors.Hand;

            btnCerrar.Name =
                "btnCerrar";

            // 
            // Controls
            // 
            Controls.Add(lblTitulo);

            Controls.Add(lblNombreTitulo);
            Controls.Add(lblCedulaTitulo);
            Controls.Add(lblLicenciaTitulo);
            Controls.Add(lblTelefonoTitulo);
            Controls.Add(lblEstadoTitulo);

            Controls.Add(lblNombre);
            Controls.Add(lblCedula);
            Controls.Add(lblLicencia);
            Controls.Add(lblTelefono);
            Controls.Add(lblEstado);

            Controls.Add(btnCerrar);

            ResumeLayout(false);
            PerformLayout();
        }
    }
}