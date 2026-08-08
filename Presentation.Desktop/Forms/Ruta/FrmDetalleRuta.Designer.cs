namespace SGA.Presentation.Desktop.Forms.Ruta
{
    partial class FrmDetalleRuta
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;

        private Label lblIdTitulo;
        private Label lblNombreTitulo;
        private Label lblOrigenTitulo;
        private Label lblDestinoTitulo;

        private Label lblId;
        private Label lblNombre;
        private Label lblOrigen;
        private Label lblDestino;

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
            lblNombreTitulo = new Label();
            lblOrigenTitulo = new Label();
            lblDestinoTitulo = new Label();

            lblId = new Label();
            lblNombre = new Label();
            lblOrigen = new Label();
            lblDestino = new Label();

            btnCerrar = new Button();

            SuspendLayout();

            // 
            // FrmDetalleRuta
            // 
            ClientSize =
                new Size(600, 380);

            Text =
                "Detalle de la Ruta";

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

            lblTitulo.Size =
                new Size(280, 41);

            lblTitulo.TabIndex = 0;

            lblTitulo.Text =
                "DETALLE DE RUTA";

            // 
            // lblIdTitulo
            // 
            lblIdTitulo.AutoSize = true;

            lblIdTitulo.Font =
                new Font(
                    "Segoe UI",
                    11F,
                    FontStyle.Bold);

            lblIdTitulo.Location =
                new Point(40, 90);

            lblIdTitulo.Name =
                "lblIdTitulo";

            lblIdTitulo.Text =
                "ID:";

            // 
            // lblNombreTitulo
            // 
            lblNombreTitulo.AutoSize = true;

            lblNombreTitulo.Font =
                new Font(
                    "Segoe UI",
                    11F,
                    FontStyle.Bold);

            lblNombreTitulo.Location =
                new Point(40, 135);

            lblNombreTitulo.Name =
                "lblNombreTitulo";

            lblNombreTitulo.Text =
                "Nombre:";

            // 
            // lblOrigenTitulo
            // 
            lblOrigenTitulo.AutoSize = true;

            lblOrigenTitulo.Font =
                new Font(
                    "Segoe UI",
                    11F,
                    FontStyle.Bold);

            lblOrigenTitulo.Location =
                new Point(40, 180);

            lblOrigenTitulo.Name =
                "lblOrigenTitulo";

            lblOrigenTitulo.Text =
                "Origen:";

            // 
            // lblDestinoTitulo
            // 
            lblDestinoTitulo.AutoSize = true;

            lblDestinoTitulo.Font =
                new Font(
                    "Segoe UI",
                    11F,
                    FontStyle.Bold);

            lblDestinoTitulo.Location =
                new Point(40, 225);

            lblDestinoTitulo.Name =
                "lblDestinoTitulo";

            lblDestinoTitulo.Text =
                "Destino:";

            // 
            // lblId
            // 
            lblId.AutoSize = true;

            lblId.Font =
                new Font(
                    "Segoe UI",
                    11F);

            lblId.Location =
                new Point(180, 90);

            lblId.Name =
                "lblId";

            lblId.Text =
                "-";

            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;

            lblNombre.Font =
                new Font(
                    "Segoe UI",
                    11F);

            lblNombre.Location =
                new Point(180, 135);

            lblNombre.Name =
                "lblNombre";

            lblNombre.Text =
                "-";

            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;

            lblOrigen.Font =
                new Font(
                    "Segoe UI",
                    11F);

            lblOrigen.Location =
                new Point(180, 180);

            lblOrigen.Name =
                "lblOrigen";

            lblOrigen.Text =
                "-";

            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;

            lblDestino.Font =
                new Font(
                    "Segoe UI",
                    11F);

            lblDestino.Location =
                new Point(180, 225);

            lblDestino.Name =
                "lblDestino";

            lblDestino.Text =
                "-";

            // 
            // btnCerrar
            // 
            btnCerrar.BackColor =
                Color.FromArgb(25, 42, 86);

            btnCerrar.Cursor =
                Cursors.Hand;

            btnCerrar.FlatStyle =
                FlatStyle.Flat;

            btnCerrar.FlatAppearance.BorderSize =
                0;

            btnCerrar.ForeColor =
                Color.White;

            btnCerrar.Location =
                new Point(230, 295);

            btnCerrar.Name =
                "btnCerrar";

            btnCerrar.Size =
                new Size(120, 40);

            btnCerrar.TabIndex = 9;

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

            Controls.Add(lblIdTitulo);
            Controls.Add(lblNombreTitulo);
            Controls.Add(lblOrigenTitulo);
            Controls.Add(lblDestinoTitulo);

            Controls.Add(lblId);
            Controls.Add(lblNombre);
            Controls.Add(lblOrigen);
            Controls.Add(lblDestino);

            Controls.Add(btnCerrar);

            ResumeLayout(false);
            PerformLayout();
        }
    }
}