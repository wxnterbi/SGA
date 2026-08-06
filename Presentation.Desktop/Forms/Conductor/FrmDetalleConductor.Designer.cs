namespace SGA.Presentation.Desktop.Forms.Conductor
{
    partial class FrmDetalleConductor
    {
        private System.ComponentModel.IContainer components = null;


        private Label lblTitulo;

        private Label lblNombre;
        private Label lblCedula;
        private Label lblLicencia;
        private Label lblTelefono;
        private Label lblEstado;



        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }



        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblNombre = new Label();
            lblCedula = new Label();
            lblLicencia = new Label();
            lblTelefono = new Label();
            lblEstado = new Label();
            SuspendLayout();
            
            // lblTitulo
            
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(100, 35);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(298, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Detalle del Conductor";
            
            // lblNombre
            
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(60, 110);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(0, 20);
            lblNombre.TabIndex = 1;
            
            // lblCedula
            
            lblCedula.AutoSize = true;
            lblCedula.Location = new Point(60, 160);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(0, 20);
            lblCedula.TabIndex = 2;
            
            // lblLicencia
            
            lblLicencia.AutoSize = true;
            lblLicencia.Location = new Point(60, 210);
            lblLicencia.Name = "lblLicencia";
            lblLicencia.Size = new Size(0, 20);
            lblLicencia.TabIndex = 3;
            
            // lblTelefono
            
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(60, 260);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(0, 20);
            lblTelefono.TabIndex = 4;
            
            // lblEstado
            
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(60, 310);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(0, 20);
            lblEstado.TabIndex = 5;
            
            // FrmDetalleConductor
            
            ClientSize = new Size(450, 400);
            Controls.Add(lblTitulo);
            Controls.Add(lblNombre);
            Controls.Add(lblCedula);
            Controls.Add(lblLicencia);
            Controls.Add(lblTelefono);
            Controls.Add(lblEstado);
            Name = "FrmDetalleConductor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalle Conductor";
            Load += FrmDetalleConductor_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}