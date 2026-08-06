namespace SGA.Presentation.Desktop.Forms.Autobus
{
    partial class FrmDetalleAutobus
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;

        private Label lblPlacaTitulo;
        private Label lblMarcaTitulo;
        private Label lblModeloTitulo;
        private Label lblCapacidadTitulo;
        private Label lblEstadoTitulo;

        private Label lblPlaca;
        private Label lblMarca;
        private Label lblModelo;
        private Label lblCapacidad;
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
            components = new System.ComponentModel.Container();

            lblTitulo = new Label();

            lblPlacaTitulo = new Label();
            lblMarcaTitulo = new Label();
            lblModeloTitulo = new Label();
            lblCapacidadTitulo = new Label();
            lblEstadoTitulo = new Label();

            lblPlaca = new Label();
            lblMarca = new Label();
            lblModelo = new Label();
            lblCapacidad = new Label();
            lblEstado = new Label();

            btnCerrar = new Button();

            SuspendLayout();

            //===========================
            // FORMULARIO
            //===========================

            ClientSize = new Size(600, 420);

            Text = "Detalle del Autobús";

            StartPosition = FormStartPosition.CenterParent;

            FormBorderStyle = FormBorderStyle.FixedDialog;

            MaximizeBox = false;

            MinimizeBox = false;

            BackColor = Color.White;

            //===========================
            // TITULO
            //===========================

            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(25, 42, 86);
            lblTitulo.Location = new Point(30, 20);

            //===========================
            // TITULOS
            //===========================

            Label[] titulos =
            {
                lblPlacaTitulo,
                lblMarcaTitulo,
                lblModeloTitulo,
                lblCapacidadTitulo,
                lblEstadoTitulo
            };

            int y = 90;

            foreach (Label lbl in titulos)
            {
                lbl.AutoSize = true;
                lbl.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
                lbl.Location = new Point(40, y);

                y += 45;
            }

            //===========================
            // VALORES
            //===========================

            Label[] valores =
            {
                lblPlaca,
                lblMarca,
                lblModelo,
                lblCapacidad,
                lblEstado
            };

            y = 90;

            foreach (Label lbl in valores)
            {
                lbl.AutoSize = true;
                lbl.Font = new Font("Segoe UI", 11F);
                lbl.Location = new Point(180, y);

                y += 45;
            }

            //===========================
            // BOTON
            //===========================

            btnCerrar.Text = "Cerrar";

            btnCerrar.Size = new Size(120, 40);

            btnCerrar.Location = new Point(230, 340);

            btnCerrar.BackColor = Color.FromArgb(25, 42, 86);

            btnCerrar.ForeColor = Color.White;

            btnCerrar.FlatStyle = FlatStyle.Flat;

            btnCerrar.FlatAppearance.BorderSize = 0;

            //===========================
            // CONTROLES
            //===========================

            Controls.Add(lblTitulo);

            Controls.Add(lblPlacaTitulo);
            Controls.Add(lblMarcaTitulo);
            Controls.Add(lblModeloTitulo);
            Controls.Add(lblCapacidadTitulo);
            Controls.Add(lblEstadoTitulo);

            Controls.Add(lblPlaca);
            Controls.Add(lblMarca);
            Controls.Add(lblModelo);
            Controls.Add(lblCapacidad);
            Controls.Add(lblEstado);

            Controls.Add(btnCerrar);

            ResumeLayout(false);

            PerformLayout();
        }
    }
}