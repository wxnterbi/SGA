namespace SGA.Presentation.Desktop.Forms.Incidencia
{
    partial class FrmDetalleIncidencia
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;

        private Label lblIdTitulo;
        private Label lblViajeTitulo;
        private Label lblConductorTitulo;
        private Label lblTipoTitulo;
        private Label lblDescripcionTitulo;
        private Label lblFechaTitulo;

        private Label lblId;
        private Label lblViaje;
        private Label lblConductor;
        private Label lblTipo;
        private Label lblDescripcion;
        private Label lblFecha;

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

            lblIdTitulo = new Label();
            lblViajeTitulo = new Label();
            lblConductorTitulo = new Label();
            lblTipoTitulo = new Label();
            lblDescripcionTitulo = new Label();
            lblFechaTitulo = new Label();

            lblId = new Label();
            lblViaje = new Label();
            lblConductor = new Label();
            lblTipo = new Label();
            lblDescripcion = new Label();
            lblFecha = new Label();

            btnCerrar = new Button();

            SuspendLayout();

            // 
            // FrmDetalleIncidencia
            // 
            ClientSize =
                new Size(650, 500);

            Text =
                "Detalle de la Incidencia";

            StartPosition =
                FormStartPosition.CenterParent;

            FormBorderStyle =
                FormBorderStyle.FixedDialog;

            MaximizeBox =
                false;

            MinimizeBox =
                false;

            BackColor =
                Color.White;

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

            lblTitulo.Text =
                "DETALLE DE LA INCIDENCIA";

            // 
            // Títulos
            // 
            Label[] titulos =
            {
                lblIdTitulo,
                lblViajeTitulo,
                lblConductorTitulo,
                lblTipoTitulo,
                lblDescripcionTitulo,
                lblFechaTitulo
            };

            string[] textos =
            {
                "ID:",
                "Viaje:",
                "Conductor:",
                "Tipo:",
                "Descripción:",
                "Fecha:"
            };

            int y = 85;

            for (int i = 0; i < titulos.Length; i++)
            {
                titulos[i].AutoSize = true;

                titulos[i].Font =
                    new Font(
                        "Segoe UI",
                        11F,
                        FontStyle.Bold);

                titulos[i].Location =
                    new Point(40, y);

                titulos[i].Text =
                    textos[i];

                y += 50;
            }

            // 
            // Valores
            // 
            Label[] valores =
            {
                lblId,
                lblViaje,
                lblConductor,
                lblTipo,
                lblDescripcion,
                lblFecha
            };

            y = 85;

            for (int i = 0; i < valores.Length; i++)
            {
                valores[i].AutoSize = true;

                valores[i].Font =
                    new Font(
                        "Segoe UI",
                        11F);

                valores[i].Location =
                    new Point(180, y);

                y += 50;
            }

            lblDescripcion.MaximumSize =
                new Size(420, 70);

            // 
            // btnCerrar
            // 
            btnCerrar.Text =
                "Cerrar";

            btnCerrar.Size =
                new Size(120, 40);

            btnCerrar.Location =
                new Point(265, 420);

            btnCerrar.BackColor =
                Color.FromArgb(25, 42, 86);

            btnCerrar.ForeColor =
                Color.White;

            btnCerrar.FlatStyle =
                FlatStyle.Flat;

            btnCerrar.FlatAppearance.BorderSize =
                0;

            btnCerrar.Name =
                "btnCerrar";

            // 
            // Controles
            // 
            Controls.Add(lblTitulo);

            Controls.Add(lblIdTitulo);
            Controls.Add(lblViajeTitulo);
            Controls.Add(lblConductorTitulo);
            Controls.Add(lblTipoTitulo);
            Controls.Add(lblDescripcionTitulo);
            Controls.Add(lblFechaTitulo);

            Controls.Add(lblId);
            Controls.Add(lblViaje);
            Controls.Add(lblConductor);
            Controls.Add(lblTipo);
            Controls.Add(lblDescripcion);
            Controls.Add(lblFecha);

            Controls.Add(btnCerrar);

            Font =
                new Font("Segoe UI", 10F);

            ResumeLayout(false);
            PerformLayout();
        }
    }
}