namespace SGA.Presentation.Desktop.Forms.Incidencia
{
    partial class FrmDetalleIncidencia
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;

        private Label lblIdTexto;
        private Label lblId;

        private Label lblViajeTexto;
        private Label lblViaje;

        private Label lblConductorTexto;
        private Label lblConductor;

        private Label lblTipoTexto;
        private Label lblTipo;

        private Label lblDescripcionTexto;
        private Label lblDescripcion;

        private Label lblFechaTexto;
        private Label lblFecha;

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
            lblIdTexto = new Label();
            lblId = new Label();
            lblViajeTexto = new Label();
            lblViaje = new Label();
            lblConductorTexto = new Label();
            lblConductor = new Label();
            lblTipoTexto = new Label();
            lblTipo = new Label();
            lblDescripcionTexto = new Label();
            lblDescripcion = new Label();
            lblFechaTexto = new Label();
            lblFecha = new Label();
            btnCerrar = new Button();
            SuspendLayout();
            // lblTitulo
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(40, 40, 40);
            lblTitulo.Location = new Point(145, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(395, 41);
            lblTitulo.Text = "DETALLE DE INCIDENCIA";
            // ID
            lblIdTexto.AutoSize = true;
            lblIdTexto.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblIdTexto.Location = new Point(60, 100);
            lblIdTexto.Text = "ID:";
            lblId.Font = new Font("Segoe UI", 11F);
            lblId.Location = new Point(230, 100);
            lblId.Size = new Size(320, 30);
            // Viaje
            lblViajeTexto.AutoSize = true;
            lblViajeTexto.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblViajeTexto.Location = new Point(60, 145);
            lblViajeTexto.Text = "Viaje:";
            lblViaje.Font = new Font("Segoe UI", 11F);
            lblViaje.Location = new Point(230, 145);
            lblViaje.Size = new Size(320, 30);
            // Conductor
            lblConductorTexto.AutoSize = true;
            lblConductorTexto.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblConductorTexto.Location = new Point(60, 190);
            lblConductorTexto.Text = "Conductor:";
            lblConductor.Font = new Font("Segoe UI", 11F);
            lblConductor.Location = new Point(230, 190);
            lblConductor.Size = new Size(320, 30);
            // Tipo
            lblTipoTexto.AutoSize = true;
            lblTipoTexto.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTipoTexto.Location = new Point(60, 235);
            lblTipoTexto.Text = "Tipo:";
            lblTipo.Font = new Font("Segoe UI", 11F);
            lblTipo.Location = new Point(230, 235);
            lblTipo.Size = new Size(320, 30);
            // Descripción
            lblDescripcionTexto.AutoSize = true;
            lblDescripcionTexto.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDescripcionTexto.Location = new Point(60, 280);
            lblDescripcionTexto.Text = "Descripción:";
            lblDescripcion.Font = new Font("Segoe UI", 11F);
            lblDescripcion.Location = new Point(230, 280);
            lblDescripcion.Size = new Size(320, 70);
            // Fecha
            lblFechaTexto.AutoSize = true;
            lblFechaTexto.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblFechaTexto.Location = new Point(60, 365);
            lblFechaTexto.Text = "Fecha:";
            lblFecha.Font = new Font("Segoe UI", 11F);
            lblFecha.Location = new Point(230, 365);
            lblFecha.Size = new Size(320, 30);
            // btnCerrar
            btnCerrar.BackColor = Color.Gray;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(235, 430);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(140, 45);
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // FrmDetalleIncidencia
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(620, 520);
            Controls.Add(lblTitulo);
            Controls.Add(lblIdTexto);
            Controls.Add(lblId);
            Controls.Add(lblViajeTexto);
            Controls.Add(lblViaje);
            Controls.Add(lblConductorTexto);
            Controls.Add(lblConductor);
            Controls.Add(lblTipoTexto);
            Controls.Add(lblTipo);
            Controls.Add(lblDescripcionTexto);
            Controls.Add(lblDescripcion);
            Controls.Add(lblFechaTexto);
            Controls.Add(lblFecha);
            Controls.Add(btnCerrar);
            Font = new Font("Segoe UI", 10F);
            Name = "FrmDetalleIncidencia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalle de Incidencia";
            Load += FrmDetalleIncidencia_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}