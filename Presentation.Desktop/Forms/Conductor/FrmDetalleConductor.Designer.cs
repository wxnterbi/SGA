namespace SGA.Presentation.Desktop.Forms.Conductor
{
    partial class FrmDetalleConductor
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;

        private Label lblNombreTexto;
        private Label lblNombre;

        private Label lblCedulaTexto;
        private Label lblCedula;

        private Label lblLicenciaTexto;
        private Label lblLicencia;

        private Label lblTelefonoTexto;
        private Label lblTelefono;

        private Label lblEstadoTexto;
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
            lblTitulo = new Label();

            lblNombreTexto = new Label();
            lblNombre = new Label();

            lblCedulaTexto = new Label();
            lblCedula = new Label();

            lblLicenciaTexto = new Label();
            lblLicencia = new Label();

            lblTelefonoTexto = new Label();
            lblTelefono = new Label();

            lblEstadoTexto = new Label();
            lblEstado = new Label();

            btnCerrar = new Button();

            SuspendLayout();

           
            // lblTitulo
           
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(40, 40, 40);
            lblTitulo.Location = new Point(150, 35);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(395, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "DETALLE DEL CONDUCTOR";

            
            // lblNombreTexto
            
            lblNombreTexto.AutoSize = true;
            lblNombreTexto.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblNombreTexto.Location = new Point(80, 120);
            lblNombreTexto.Text = "Nombre:";

            
            // lblNombre
            
            lblNombre.Font = new Font("Segoe UI", 11F);
            lblNombre.Location = new Point(250, 120);
            lblNombre.Size = new Size(280, 30);

            
            // lblCedulaTexto
            
            lblCedulaTexto.AutoSize = true;
            lblCedulaTexto.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblCedulaTexto.Location = new Point(80, 170);
            lblCedulaTexto.Text = "Cédula:";

            
            // lblCedula
           
            lblCedula.Font = new Font("Segoe UI", 11F);
            lblCedula.Location = new Point(250, 170);
            lblCedula.Size = new Size(280, 30);

           
            // lblLicenciaTexto
            
            lblLicenciaTexto.AutoSize = true;
            lblLicenciaTexto.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblLicenciaTexto.Location = new Point(80, 220);
            lblLicenciaTexto.Text = "Licencia:";

            
            // lblLicencia
            
            lblLicencia.Font = new Font("Segoe UI", 11F);
            lblLicencia.Location = new Point(250, 220);
            lblLicencia.Size = new Size(280, 30);

            
            // lblTelefonoTexto
            
            lblTelefonoTexto.AutoSize = true;
            lblTelefonoTexto.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTelefonoTexto.Location = new Point(80, 270);
            lblTelefonoTexto.Text = "Teléfono:";

            
            // lblTelefono
            
            lblTelefono.Font = new Font("Segoe UI", 11F);
            lblTelefono.Location = new Point(250, 270);
            lblTelefono.Size = new Size(280, 30);

            
            // lblEstadoTexto
            
            lblEstadoTexto.AutoSize = true;
            lblEstadoTexto.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblEstadoTexto.Location = new Point(80, 320);
            lblEstadoTexto.Text = "Estado:";

            
            // lblEstado
            
            lblEstado.Font = new Font("Segoe UI", 11F);
            lblEstado.Location = new Point(250, 320);
            lblEstado.Size = new Size(280, 30);

            
            // btnCerrar
            
            btnCerrar.BackColor = Color.Gray;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(270, 410);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(140, 45);
            btnCerrar.TabIndex = 20;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;

            
            // FrmDetalleConductor
            
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(650, 500);

            Controls.Add(lblTitulo);

            Controls.Add(lblNombreTexto);
            Controls.Add(lblNombre);

            Controls.Add(lblCedulaTexto);
            Controls.Add(lblCedula);

            Controls.Add(lblLicenciaTexto);
            Controls.Add(lblLicencia);

            Controls.Add(lblTelefonoTexto);
            Controls.Add(lblTelefono);

            Controls.Add(lblEstadoTexto);
            Controls.Add(lblEstado);

            Controls.Add(btnCerrar);

            Font = new Font("Segoe UI", 10F);
            Name = "FrmDetalleConductor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalle del Conductor";

            Load += FrmDetalleConductor_Load_1;

            ResumeLayout(false);
            PerformLayout();
        }
    }
}