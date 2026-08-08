namespace SGA.Presentation.Desktop.Forms.Parada
{
    partial class FrmDetalleParada
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;

        private Label lblIdTitulo;
        private Label lblNombreTitulo;
        private Label lblUbicacionTitulo;
        private Label lblOrdenTitulo;

        private Label lblId;
        private Label lblNombre;
        private Label lblUbicacion;
        private Label lblOrden;

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
            lblUbicacionTitulo = new Label();
            lblOrdenTitulo = new Label();

            lblId = new Label();
            lblNombre = new Label();
            lblUbicacion = new Label();
            lblOrden = new Label();

            btnCerrar = new Button();

            SuspendLayout();

            // 
            // FrmDetalleParada
            // 
            ClientSize =
                new Size(600, 380);

            Text =
                "Detalle de la Parada";

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

            Font =
                new Font("Segoe UI", 10F);

            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;

            lblTitulo.Font =
                new Font("Segoe UI", 18F, FontStyle.Bold);

            lblTitulo.ForeColor =
                Color.FromArgb(25, 42, 86);

            lblTitulo.Location =
                new Point(30, 20);

            lblTitulo.Name =
                "lblTitulo";

            lblTitulo.Text =
                "DETALLE DE LA PARADA";

            // 
            // lblIdTitulo
            // 
            lblIdTitulo.AutoSize = true;

            lblIdTitulo.Font =
                new Font("Segoe UI", 11F, FontStyle.Bold);

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
                new Font("Segoe UI", 11F, FontStyle.Bold);

            lblNombreTitulo.Location =
                new Point(40, 135);

            lblNombreTitulo.Name =
                "lblNombreTitulo";

            lblNombreTitulo.Text =
                "Nombre:";

            // 
            // lblUbicacionTitulo
            // 
            lblUbicacionTitulo.AutoSize = true;

            lblUbicacionTitulo.Font =
                new Font("Segoe UI", 11F, FontStyle.Bold);

            lblUbicacionTitulo.Location =
                new Point(40, 180);

            lblUbicacionTitulo.Name =
                "lblUbicacionTitulo";

            lblUbicacionTitulo.Text =
                "Ubicación:";

            // 
            // lblOrdenTitulo
            // 
            lblOrdenTitulo.AutoSize = true;

            lblOrdenTitulo.Font =
                new Font("Segoe UI", 11F, FontStyle.Bold);

            lblOrdenTitulo.Location =
                new Point(40, 225);

            lblOrdenTitulo.Name =
                "lblOrdenTitulo";

            lblOrdenTitulo.Text =
                "Orden:";

            // 
            // lblId
            // 
            lblId.AutoSize = true;

            lblId.Font =
                new Font("Segoe UI", 11F);

            lblId.Location =
                new Point(180, 90);

            lblId.Name =
                "lblId";

            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;

            lblNombre.Font =
                new Font("Segoe UI", 11F);

            lblNombre.Location =
                new Point(180, 135);

            lblNombre.Name =
                "lblNombre";

            lblNombre.MaximumSize =
                new Size(350, 0);

            // 
            // lblUbicacion
            // 
            lblUbicacion.AutoSize = true;

            lblUbicacion.Font =
                new Font("Segoe UI", 11F);

            lblUbicacion.Location =
                new Point(180, 180);

            lblUbicacion.Name =
                "lblUbicacion";

            lblUbicacion.MaximumSize =
                new Size(350, 0);

            // 
            // lblOrden
            // 
            lblOrden.AutoSize = true;

            lblOrden.Font =
                new Font("Segoe UI", 11F);

            lblOrden.Location =
                new Point(180, 225);

            lblOrden.Name =
                "lblOrden";

            // 
            // btnCerrar
            // 
            btnCerrar.Text =
                "Cerrar";

            btnCerrar.Size =
                new Size(120, 40);

            btnCerrar.Location =
                new Point(230, 300);

            btnCerrar.BackColor =
                Color.FromArgb(0, 120, 215);

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

            Controls.Add(lblIdTitulo);
            Controls.Add(lblNombreTitulo);
            Controls.Add(lblUbicacionTitulo);
            Controls.Add(lblOrdenTitulo);

            Controls.Add(lblId);
            Controls.Add(lblNombre);
            Controls.Add(lblUbicacion);
            Controls.Add(lblOrden);

            Controls.Add(btnCerrar);

            ResumeLayout(false);
            PerformLayout();
        }
    }
}